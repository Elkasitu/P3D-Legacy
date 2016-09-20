Namespace Items.Standard

    <Item(180, "Brick Piece")>
    Public Class BrickPiece

        Inherits Item

        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(72, 240, 24, 24)
        End Sub

    End Class

End Namespace
