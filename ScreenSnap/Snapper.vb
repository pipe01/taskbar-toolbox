Imports System.Runtime.InteropServices
Imports System.Drawing

Public Module Snapper
    Private Const mSnapOffset As Integer = 10
    Public Const WM_WINDOWPOSCHANGING As Integer = &H46

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure WINDOWPOS
        Public hwnd As IntPtr
        Public hwndInsertAfter As IntPtr
        Public x As Integer
        Public y As Integer
        Public cx As Integer
        Public cy As Integer
        Public flags As Integer
    End Structure

    Public Sub SnapToDesktopBorder(ByVal clientForm _
           As Form, ByVal LParam As IntPtr, ByVal widthAdjustment As Integer, _
           ByVal bottomAdj As Integer, ByVal rightAdj As Integer)
        If clientForm Is Nothing Then
            ' Satisfies rule: Validate parameters
            Throw New ArgumentNullException("clientForm")
        End If

        ' Snap client to the top, left, bottom or right desktop border
        ' as the form is moved near that border.

        Try
            ' Marshal the LPARAM value which is a WINDOWPOS struct
            Dim NewPosition As New WINDOWPOS
            NewPosition = CType(Runtime.InteropServices.Marshal.PtrToStructure( _
                LParam, GetType(WINDOWPOS)), WINDOWPOS)

            If NewPosition.y = 0 OrElse NewPosition.x = 0 Then
                Return ' Nothing to do!
            End If

            ' Adjust the client size for borders and caption bar
            Dim ClientRect As Rectangle = _
                clientForm.RectangleToScreen(clientForm.ClientRectangle)
            'ClientRect.Width += _
            'SystemInformation.FrameBorderSize.Width(-widthAdjustment)
            'ClientRect.Height += (SystemInformation.FrameBorderSize.Height + _
            '                      SystemInformation.CaptionHeight)

            ' Now get the screen working area (without taskbar)
            Dim WorkingRect As Rectangle = _
                Screen.GetWorkingArea(clientForm.ClientRectangle)

            ' Left border
            If NewPosition.x >= WorkingRect.X - mSnapOffset AndAlso _
                NewPosition.x <= WorkingRect.X + mSnapOffset Then
                NewPosition.x = WorkingRect.X
            End If

            ' Get screen bounds and taskbar height
            ' (when taskbar is horizontal)
            Dim ScreenRect As Rectangle = _
                Screen.GetBounds(Screen.PrimaryScreen.Bounds)
            Dim TaskbarHeight As Integer = _
                ScreenRect.Height - WorkingRect.Height

            ' Top border (check if taskbar is on top
            ' or bottom via WorkingRect.Y)
            If NewPosition.y >= -mSnapOffset AndAlso _
                 (WorkingRect.Y > 0 AndAlso NewPosition.y <= _
                 (TaskbarHeight + mSnapOffset)) OrElse _
                 (WorkingRect.Y <= 0 AndAlso NewPosition.y <= _
                 (mSnapOffset)) Then
                If TaskbarHeight > 0 Then
                    NewPosition.y = WorkingRect.Y ' Horizontal Taskbar
                Else
                    NewPosition.y = 0 ' Vertical Taskbar
                End If
            End If

            ' Right border
            If NewPosition.x + ClientRect.Width <= _
                 WorkingRect.Right + mSnapOffset AndAlso _
                 NewPosition.x + ClientRect.Width >= _
                 WorkingRect.Right - mSnapOffset Then
                NewPosition.x = WorkingRect.Right - (ClientRect.Width + _
                                SystemInformation.FrameBorderSize.Width) + rightAdj
            End If

            ' Bottom border
            If NewPosition.y + ClientRect.Height <= _
                   WorkingRect.Bottom + mSnapOffset AndAlso _
                   NewPosition.y + ClientRect.Height >= _
                   WorkingRect.Bottom - mSnapOffset Then
                NewPosition.y = WorkingRect.Bottom - (ClientRect.Height + _
                                SystemInformation.FrameBorderSize.Height) + bottomAdj
            End If

            ' Marshal it back
            Runtime.InteropServices.Marshal.StructureToPtr(NewPosition, _
                                                           LParam, True)
        Catch ex As ArgumentException
        End Try
    End Sub
End Module
