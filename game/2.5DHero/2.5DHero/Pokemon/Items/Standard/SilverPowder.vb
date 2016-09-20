Namespace Items.Standard

    <Item(88, "SilverPowder")>
    Public Class SilverPowder

        Inherits Item

        Public Overrides ReadOnly Property FlingDamage As Integer = 10
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(312, 72, 24, 24)
        End Sub

    End Class

End Namespace
