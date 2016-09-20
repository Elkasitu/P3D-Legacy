Namespace Items.Standard

    <Item(505, "Toxic Orb")>
    Public Class ToxicOrb

        Inherits Item

        Public Overrides ReadOnly Property BattlePointsPrice As Integer = 16
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(216, 240, 24, 24)
        End Sub

    End Class

End Namespace
