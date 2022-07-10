using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000376_bf {
    public static class _01_main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3500, 3501, 3010, 3011, 3012, 3013, 3030, 3506, 3507, 3502, 3503, 3504, 3505}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "or_fi_struc_stonegate_A01_off");
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Closed");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5004}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003}, visible: true);
                context.SetUserValue(key: "PuzzleSolved", value: 0);
                context.SetUserValue(key: "PatrolEnd", value: 0);
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{100, 200, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 950, 951, 952, 953, 954, 955, 956, 958, 959, 961, 963, 964, 965, 966, 969, 970, 973, 974, 976, 977, 978, 979, 981}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3506, 3507}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000376_BF__01_MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4003, visible: false, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3502, 3503, 3504, 3505}, visible: false, arg3: 0, arg4: 100, arg5: 5f);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_100");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_200");
                context.SetConversation(type: 1, spawnId: 200, script: "$02000376_BF__01_MAIN__1$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000376_BF__01_MAIN__2$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PatrolEnd") == 1) {
                    return new StateNpcPatrol03(context);
                }

                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol03 : TriggerState {
            internal StateNpcPatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9400, spawnIds: new []{202})) {
                    return new StateNpcPatrol04(context);
                }

                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol04 : TriggerState {
            internal StateNpcPatrol04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9400) == 1) {
                    return new StateFoundTotem01(context);
                }

                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201, 102, 202});
                context.CreateMonster(spawnIds: new []{105, 205}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{101, 201, 102, 202, 103, 203});
                context.CreateMonster(spawnIds: new []{105, 205}, arg2: false);
                context.RemoveBalloonTalk(spawnId: 203);
                context.RemoveBalloonTalk(spawnId: 103);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{101, 201, 102, 202});
                context.CreateMonster(spawnIds: new []{103, 203}, arg2: false);
                context.SetConversation(type: 1, spawnId: 203, script: "$02000376_BF__01_MAIN__3$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 103, script: "$02000376_BF__01_MAIN__4$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRemoveTotem01(context);
                }

                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateNpcChange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem01 : TriggerState {
            internal StateRemoveTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateRemoveTotem02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101, 201, 102, 202, 103, 203});
                context.CreateMonster(spawnIds: new []{105, 205}, arg2: false);
                context.RemoveBalloonTalk(spawnId: 203);
                context.RemoveBalloonTalk(spawnId: 103);
            }
        }

        private class StateRemoveTotem02 : TriggerState {
            internal StateRemoveTotem02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201, 102, 202});
                context.MoveNpc(spawnId: 950, patrolName: "MS2PatrolData_850");
                context.MoveNpc(spawnId: 951, patrolName: "MS2PatrolData_851");
                context.MoveNpc(spawnId: 952, patrolName: "MS2PatrolData_852");
                context.MoveNpc(spawnId: 953, patrolName: "MS2PatrolData_853");
                context.MoveNpc(spawnId: 954, patrolName: "MS2PatrolData_854");
                context.MoveNpc(spawnId: 955, patrolName: "MS2PatrolData_855");
                context.MoveNpc(spawnId: 956, patrolName: "MS2PatrolData_856");
                context.MoveNpc(spawnId: 958, patrolName: "MS2PatrolData_858");
                context.MoveNpc(spawnId: 959, patrolName: "MS2PatrolData_859");
                context.MoveNpc(spawnId: 961, patrolName: "MS2PatrolData_861");
                context.MoveNpc(spawnId: 963, patrolName: "MS2PatrolData_863");
                context.MoveNpc(spawnId: 964, patrolName: "MS2PatrolData_864");
                context.MoveNpc(spawnId: 965, patrolName: "MS2PatrolData_865");
                context.MoveNpc(spawnId: 966, patrolName: "MS2PatrolData_866");
                context.MoveNpc(spawnId: 969, patrolName: "MS2PatrolData_869");
                context.MoveNpc(spawnId: 970, patrolName: "MS2PatrolData_870");
                context.MoveNpc(spawnId: 973, patrolName: "MS2PatrolData_873");
                context.MoveNpc(spawnId: 974, patrolName: "MS2PatrolData_874");
                context.MoveNpc(spawnId: 976, patrolName: "MS2PatrolData_876");
                context.MoveNpc(spawnId: 977, patrolName: "MS2PatrolData_877");
                context.MoveNpc(spawnId: 978, patrolName: "MS2PatrolData_878");
                context.MoveNpc(spawnId: 979, patrolName: "MS2PatrolData_879");
                context.MoveNpc(spawnId: 981, patrolName: "MS2PatrolData_881");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{102, 202});
                context.ChangeMonster(removeSpawnId: 950, addSpawnId: 850);
                context.ChangeMonster(removeSpawnId: 951, addSpawnId: 851);
                context.ChangeMonster(removeSpawnId: 952, addSpawnId: 852);
                context.ChangeMonster(removeSpawnId: 953, addSpawnId: 853);
                context.ChangeMonster(removeSpawnId: 954, addSpawnId: 854);
                context.ChangeMonster(removeSpawnId: 955, addSpawnId: 855);
                context.ChangeMonster(removeSpawnId: 956, addSpawnId: 856);
                context.ChangeMonster(removeSpawnId: 958, addSpawnId: 858);
                context.ChangeMonster(removeSpawnId: 959, addSpawnId: 859);
                context.ChangeMonster(removeSpawnId: 961, addSpawnId: 861);
                context.ChangeMonster(removeSpawnId: 963, addSpawnId: 863);
                context.ChangeMonster(removeSpawnId: 964, addSpawnId: 864);
                context.ChangeMonster(removeSpawnId: 965, addSpawnId: 865);
                context.ChangeMonster(removeSpawnId: 966, addSpawnId: 866);
                context.ChangeMonster(removeSpawnId: 968, addSpawnId: 868);
                context.ChangeMonster(removeSpawnId: 969, addSpawnId: 869);
                context.ChangeMonster(removeSpawnId: 970, addSpawnId: 870);
                context.ChangeMonster(removeSpawnId: 973, addSpawnId: 873);
                context.ChangeMonster(removeSpawnId: 974, addSpawnId: 874);
                context.ChangeMonster(removeSpawnId: 976, addSpawnId: 876);
                context.ChangeMonster(removeSpawnId: 977, addSpawnId: 877);
                context.ChangeMonster(removeSpawnId: 978, addSpawnId: 878);
                context.ChangeMonster(removeSpawnId: 979, addSpawnId: 879);
                context.ChangeMonster(removeSpawnId: 981, addSpawnId: 881);
                context.SetConversation(type: 1, spawnId: 105, script: "$02000376_BF__01_MAIN__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{102, 202});
                context.SetConversation(type: 1, spawnId: 205, script: "$02000376_BF__01_MAIN__6$", arg4: 3, arg5: 2);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_106");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_206");
                context.SetMesh(triggerIds: new []{3500, 3501}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Opened");
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{102, 202});
                context.SetConversation(type: 1, spawnId: 205, script: "$02000376_BF__01_MAIN__7$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_107");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_207");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9500, spawnIds: new []{105})) {
                    return new StateFoundGate02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFoundGate02 : TriggerState {
            internal StateFoundGate02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 105, script: "$02000376_BF__01_MAIN__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9501, spawnIds: new []{105})) {
                    return new StateShadowApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp01 : TriggerState {
            internal StateShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 205, script: "$02000376_BF__01_MAIN__9$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{105, 205});
                context.CreateMonster(spawnIds: new []{106, 206}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000376_BF__01_MAIN__10$", duration: 3000, boxId: 0);
                context.CreateMonster(spawnIds: new []{911, 912, 913, 914, 915, 916, 917, 918}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{921, 922, 923, 924, 925, 926, 927, 928}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{931, 932, 933, 934, 935, 936, 937, 938}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 911, 912, 913, 914, 915, 916, 917, 918, 921, 922, 923, 924, 925, 926, 927, 928, 931, 932, 933, 934, 935, 936, 937, 938})) {
                    return new StateStartPuzzle01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{106, 206});
                context.CreateMonster(spawnIds: new []{104, 204}, arg2: false);
            }
        }

        private class StateStartPuzzle01 : TriggerState {
            internal StateStartPuzzle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "PuzzleStart", value: 1);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000376_BF__01_MAIN__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000376_BF__01_MAIN__12$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_108");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_208");
                context.SetConversation(type: 1, spawnId: 104, script: "$02000376_BF__01_MAIN__13$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 204, script: "$02000376_BF__01_MAIN__14$", arg4: 2, arg5: 2);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "or_fi_struc_stonegate_A01_on");
                context.SetMesh(triggerIds: new []{3030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_109");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_209");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{104, 204});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
