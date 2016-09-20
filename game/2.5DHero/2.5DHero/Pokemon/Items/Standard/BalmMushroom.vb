Namespace Items.Standard

    <Item(153, "Balm Mushroom")>
    Public Class BalmMushroom

        Inherits Item

        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(48, 216, 24, 24)
        End Sub

    End Class

End Namespace
