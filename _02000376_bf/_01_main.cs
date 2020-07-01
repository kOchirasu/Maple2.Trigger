using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000376_bf {
    public static class _01_main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3500, 3501, 3010, 3011, 3012, 3013, 3030, 3506, 3507, 3502, 3503, 3504, 3505}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4000, arg2: true, arg3: "or_fi_struc_stonegate_A01_off");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5004}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003}, arg2: true);
                context.SetUserValue(key: "PuzzleSolved", value: 0);
                context.SetUserValue(key: "PatrolEnd", value: 0);
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100, 200, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 950, 951, 952, 953, 954, 955, 956, 958, 959, 961, 963, 964, 965, 966, 969, 970, 973, 974, 976, 977, 978, 979, 981}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcMonologue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11, key: "DungeonStart", value: 1);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3506, 3507}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000376_BF__01_MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNpcMonologue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4003, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3502, 3503, 3504, 3505}, arg2: false, arg3: 0, arg4: 100, arg5: 5f);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_100");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_200");
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000376_BF__01_MAIN__1$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNpcPatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol01 : TriggerState {
            internal StateNpcPatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10, key: "PatrolStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcPatrol02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol02 : TriggerState {
            internal StateNpcPatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000376_BF__01_MAIN__2$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PatrolEnd") == 1) {
                    return new StateNpcPatrol03(context);
                }

                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol03 : TriggerState {
            internal StateNpcPatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9400, arg2: new[] {202})) {
                    return new StateNpcPatrol04(context);
                }

                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol04 : TriggerState {
            internal StateNpcPatrol04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9400) == 1) {
                    return new StateFoundTotem01(context);
                }

                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201, 102, 202});
                context.CreateMonster(arg1: new[] {105, 205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRemoveTotem02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange02 : TriggerState {
            internal StateNpcChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201, 102, 202, 103, 203});
                context.CreateMonster(arg1: new[] {105, 205}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 203);
                context.RemoveBalloonTalk(spawnPointId: 103);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRemoveTotem02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFoundTotem01 : TriggerState {
            internal StateFoundTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201, 102, 202});
                context.CreateMonster(arg1: new[] {103, 203}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000376_BF__01_MAIN__3$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000376_BF__01_MAIN__4$", arg4: 3, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRemoveTotem01(context);
                }

                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateNpcChange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem01 : TriggerState {
            internal StateRemoveTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateRemoveTotem02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 201, 102, 202, 103, 203});
                context.CreateMonster(arg1: new[] {105, 205}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 203);
                context.RemoveBalloonTalk(spawnPointId: 103);
            }
        }

        private class StateRemoveTotem02 : TriggerState {
            internal StateRemoveTotem02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201, 102, 202});
                context.MoveNpc(arg1: 950, arg2: "MS2PatrolData_850");
                context.MoveNpc(arg1: 951, arg2: "MS2PatrolData_851");
                context.MoveNpc(arg1: 952, arg2: "MS2PatrolData_852");
                context.MoveNpc(arg1: 953, arg2: "MS2PatrolData_853");
                context.MoveNpc(arg1: 954, arg2: "MS2PatrolData_854");
                context.MoveNpc(arg1: 955, arg2: "MS2PatrolData_855");
                context.MoveNpc(arg1: 956, arg2: "MS2PatrolData_856");
                context.MoveNpc(arg1: 958, arg2: "MS2PatrolData_858");
                context.MoveNpc(arg1: 959, arg2: "MS2PatrolData_859");
                context.MoveNpc(arg1: 961, arg2: "MS2PatrolData_861");
                context.MoveNpc(arg1: 963, arg2: "MS2PatrolData_863");
                context.MoveNpc(arg1: 964, arg2: "MS2PatrolData_864");
                context.MoveNpc(arg1: 965, arg2: "MS2PatrolData_865");
                context.MoveNpc(arg1: 966, arg2: "MS2PatrolData_866");
                context.MoveNpc(arg1: 969, arg2: "MS2PatrolData_869");
                context.MoveNpc(arg1: 970, arg2: "MS2PatrolData_870");
                context.MoveNpc(arg1: 973, arg2: "MS2PatrolData_873");
                context.MoveNpc(arg1: 974, arg2: "MS2PatrolData_874");
                context.MoveNpc(arg1: 976, arg2: "MS2PatrolData_876");
                context.MoveNpc(arg1: 977, arg2: "MS2PatrolData_877");
                context.MoveNpc(arg1: 978, arg2: "MS2PatrolData_878");
                context.MoveNpc(arg1: 979, arg2: "MS2PatrolData_879");
                context.MoveNpc(arg1: 981, arg2: "MS2PatrolData_881");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRemoveTotem03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem03 : TriggerState {
            internal StateRemoveTotem03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102, 202});
                context.ChangeMonster(arg1: 950, arg2: 850);
                context.ChangeMonster(arg1: 951, arg2: 851);
                context.ChangeMonster(arg1: 952, arg2: 852);
                context.ChangeMonster(arg1: 953, arg2: 853);
                context.ChangeMonster(arg1: 954, arg2: 854);
                context.ChangeMonster(arg1: 955, arg2: 855);
                context.ChangeMonster(arg1: 956, arg2: 856);
                context.ChangeMonster(arg1: 958, arg2: 858);
                context.ChangeMonster(arg1: 959, arg2: 859);
                context.ChangeMonster(arg1: 961, arg2: 861);
                context.ChangeMonster(arg1: 963, arg2: 863);
                context.ChangeMonster(arg1: 964, arg2: 864);
                context.ChangeMonster(arg1: 965, arg2: 865);
                context.ChangeMonster(arg1: 966, arg2: 866);
                context.ChangeMonster(arg1: 968, arg2: 868);
                context.ChangeMonster(arg1: 969, arg2: 869);
                context.ChangeMonster(arg1: 970, arg2: 870);
                context.ChangeMonster(arg1: 973, arg2: 873);
                context.ChangeMonster(arg1: 974, arg2: 874);
                context.ChangeMonster(arg1: 976, arg2: 876);
                context.ChangeMonster(arg1: 977, arg2: 877);
                context.ChangeMonster(arg1: 978, arg2: 878);
                context.ChangeMonster(arg1: 979, arg2: 879);
                context.ChangeMonster(arg1: 981, arg2: 881);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$02000376_BF__01_MAIN__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRemoveTotem04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem04 : TriggerState {
            internal StateRemoveTotem04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102, 202});
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$02000376_BF__01_MAIN__6$", arg4: 3, arg5: 2);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_106");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_206");
                context.SetMesh(arg1: new[] {3500, 3501}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFoundGate01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFoundGate01 : TriggerState {
            internal StateFoundGate01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102, 202});
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$02000376_BF__01_MAIN__7$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_107");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_207");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9500, arg2: new[] {105})) {
                    return new StateFoundGate02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFoundGate02 : TriggerState {
            internal StateFoundGate02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$02000376_BF__01_MAIN__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9501, arg2: new[] {105})) {
                    return new StateShadowApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp01 : TriggerState {
            internal StateShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 205, arg3: "$02000376_BF__01_MAIN__9$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateShadowApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp02 : TriggerState {
            internal StateShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105, 205});
                context.CreateMonster(arg1: new[] {106, 206}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000376_BF__01_MAIN__10$", arg3: 3000, arg4: "0");
                context.CreateMonster(arg1: new[] {911, 912, 913, 914, 915, 916, 917, 918}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateShadowApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp03 : TriggerState {
            internal StateShadowApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {921, 922, 923, 924, 925, 926, 927, 928}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateShadowApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp04 : TriggerState {
            internal StateShadowApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {931, 932, 933, 934, 935, 936, 937, 938}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 911, 912, 913, 914, 915, 916, 917, 918, 921, 922, 923, 924, 925, 926, 927, 928, 931, 932, 933, 934, 935, 936, 937, 938})) {
                    return new StateStartPuzzle01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {106, 206});
                context.CreateMonster(arg1: new[] {104, 204}, arg2: false);
            }
        }

        private class StateStartPuzzle01 : TriggerState {
            internal StateStartPuzzle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "PuzzleStart", value: 1);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000376_BF__01_MAIN__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartPuzzle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPuzzle02 : TriggerState {
            internal StateStartPuzzle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000376_BF__01_MAIN__12$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEndPuzzle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndPuzzle01 : TriggerState {
            internal StateEndPuzzle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PuzzleSolved") == 1) {
                    return new StateGateOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen02 : TriggerState {
            internal StateGateOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_108");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_208");
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000376_BF__01_MAIN__13$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$02000376_BF__01_MAIN__14$", arg4: 2, arg5: 2);
                context.SetActor(arg1: 4000, arg2: true, arg3: "or_fi_struc_stonegate_A01_on");
                context.SetMesh(arg1: new[] {3030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGateOpen03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen03 : TriggerState {
            internal StateGateOpen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_109");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_209");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104, 204});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}