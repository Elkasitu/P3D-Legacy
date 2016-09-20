Namespace Items.Standard

    <Item(167, "DeepSeaTooth")>
    Public Class DeepSeaTooth

        Inherits Item

        Public Overrides ReadOnly Property FlingDamage As Integer = 90
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(312, 216, 24, 24)
        End Sub

    End Class

End Namespace
