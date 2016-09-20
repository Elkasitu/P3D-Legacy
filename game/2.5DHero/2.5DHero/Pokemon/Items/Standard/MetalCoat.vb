Namespace Items.Standard

    <Item(143, "Metal Coat")>
    Public Class MetalCoat

        Inherits Item

        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(408, 120, 24, 24)
        End Sub

    End Class

End Namespace
