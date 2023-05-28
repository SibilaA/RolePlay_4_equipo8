namespace RoleplayGame.Items
{
    public interface IGemas: IAttackItem , IDefenseItem
    {
        new int AttackPower { get; }
        new int DefensePower { get;}

    }
}