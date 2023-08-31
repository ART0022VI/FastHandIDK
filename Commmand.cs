using CommandSystem;
using Exiled.API.Features;
using Exiled.Events.Commands.Reload;
using MEC;
using System;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace FastHandidk
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Commmand : ICommand
    {
        public string Command => "runddoser";
        public string Description => "запускает ДДОСЕРа ";
        public string[] Aliases => null;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Random random= new Random();
            int plboss = random.Next(Player.List.Count()+2);
            Player bosspl = Player.Get(plboss);
            bool boss = false;
            Log.Info("1231231312");
            Log.Info(plboss);
            foreach (Player pl in Player.List)
            {
                Log.Info("1231231312");
                if (pl.Id == plboss && !boss)
                {
                    foreach(Door door in Door.List)
                    {
                        door.Lock(1230123012302103f, Exiled.API.Enums.DoorLockType.Isolation);
                    }
                    pl.Role.Set(PlayerRoles.RoleTypeId.ChaosRepressor, Exiled.API.Enums.SpawnReason.None);
                    pl.ClearInventory();
                    MEC.Timing.CallDelayed(1f, () => { pl.Position = new Vector3(12.757f, 992.605f, -42.839f); });
                    pl.AddItem(ItemType.GunLogicer);
                    pl.Health = 10000;
                    boss = true;
                }
                else
                {
                    pl.Role.Set(PlayerRoles.RoleTypeId.NtfSergeant, Exiled.API.Enums.SpawnReason.None);
                    Timing.CallDelayed(1f, () => { pl.Position = new Vector3(131.359f, 996.835f, -43.242f); });
                    pl.AddItem(ItemType.GunE11SR);
                }
            }

            response = $"<color=green>Бой начался</color>";
            return true;
        }
    }
}   