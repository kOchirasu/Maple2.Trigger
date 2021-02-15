namespace Maple2.Trigger._02000290_bf {
    public static class _main_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {905, 906, 907, 908}, arg2: true);
                context.SetLadder(arg1: 531, arg2: false, arg3: false);
                context.SetLadder(arg1: 532, arg2: false, arg3: false);
                context.SetLadder(arg1: 533, arg2: false, arg3: false);
                context.SetLadder(arg1: 534, arg2: false, arg3: false);
                context.SetLadder(arg1: 535, arg2: false, arg3: false);
                context.SetLadder(arg1: 536, arg2: false, arg3: false);
                context.SetMesh(arg1: new[] {3089}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3108}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3110, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3111, 3112, 3113, 3114, 3115, 3116, 3117}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3120, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.DestroyMonster(arg1: new[] {1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019});
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {6003, 6004, 6005, 6006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20002903, textId: 20002903);
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetLadder(arg1: 531, arg2: true, arg3: true);
                context.SetLadder(arg1: 532, arg2: true, arg3: true);
                context.SetLadder(arg1: 533, arg2: true, arg3: true);
                context.SetLadder(arg1: 534, arg2: true, arg3: true);
                context.SetLadder(arg1: 535, arg2: true, arg3: true);
                context.SetLadder(arg1: 536, arg2: true, arg3: true);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 9991, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 9992, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20002903);
                    return new StateTrigger09시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger09시작 : TriggerState {
            internal StateTrigger09시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1011})) {
                    return new StateTrigger10시작(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateTrigger10시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger10시작 : TriggerState {
            internal StateTrigger10시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {905, 906}, arg2: false);
                context.SetMesh(arg1: new[] {3089}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                context.CreateMonster(arg1: new[] {1012, 1013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1012, 1013})) {
                    return new StateTrigger11시작(context);
                }

                if (context.WaitTick(waitTick: 12000)) {
                    return new StateTrigger11시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger11시작 : TriggerState {
            internal StateTrigger11시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {907, 908}, arg2: false);
                context.SetMesh(arg1: new[] {3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                context.CreateMonster(arg1: new[] {1014, 1015, 1016}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1014, 1015, 1016})) {
                    return new StateTrigger12시작(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new StateTrigger12시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger12시작 : TriggerState {
            internal StateTrigger12시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3110, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1017, 1018, 1019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger12진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger12진행 : TriggerState {
            internal StateTrigger12진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3110, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3112, 3113, 3114, 3115, 3116, 3117}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1017, 1018, 1019})) {
                    return new StateTrigger13시작(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new StateTrigger13시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger13시작 : TriggerState {
            internal StateTrigger13시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3120, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3121}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger13진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger13진행 : TriggerState {
            internal StateTrigger13진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3120, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 9991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 9992, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new StateCinematicWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicWait : TriggerState {
            internal StateCinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 801, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504}, arg2: false, arg3: 0, arg4: 300, arg5: 3f);
                context.SetSkip(arg1: "StopCinematic");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {801}, arg2: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return new State공주구출(context);
            }

            public override void OnExit() { }
        }

        private class State공주구출 : TriggerState {
            internal State공주구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 801, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 20002904, textId: 20002904);
                context.SetInteractObject(arg1: new[] {10000464}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000464}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002904);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000290_BF__MAIN_2__2$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {910});
                context.CreateMonster(arg1: new[] {911});
                context.CreateMonster(arg1: new[] {912});
                context.CreateMonster(arg1: new[] {913});
                context.CreateMonster(arg1: new[] {914});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 910, arg2: "MS2PatrolData910");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 911, arg2: "MS2PatrolData911");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동03 : TriggerState {
            internal StateNPC이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 912, arg2: "MS2PatrolData912");
                context.MoveNpc(arg1: 914, arg2: "MS2PatrolData914");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동04 : TriggerState {
            internal StateNPC이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 913, arg2: "MS2PatrolData913");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(arg1: 1, arg2: 910, arg3: "$02000290_BF__MAIN_2__4$", arg4: 3);
                    context.SetEffect(arg1: new[] {6003}, arg2: true);
                    return new StateNPCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02 : TriggerState {
            internal StateNPCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 911, arg3: "$02000290_BF__MAIN_2__5$", arg4: 3);
                    context.SetEffect(arg1: new[] {6004}, arg2: true);
                    return new StateNPCScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript03 : TriggerState {
            internal StateNPCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 912, arg3: "$02000290_BF__MAIN_2__6$", arg4: 3);
                    context.SetEffect(arg1: new[] {6005}, arg2: true);
                    return new StateNPCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript04 : TriggerState {
            internal StateNPCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 913, arg3: "$02000290_BF__MAIN_2__7$", arg4: 3);
                    context.SetEffect(arg1: new[] {6006}, arg2: true);
                    context.HideGuideSummary(entityId: 20002905);
                    return new StateEndWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndWait : TriggerState {
            internal StateEndWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
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
                context.SetAchievement(arg1: 99999, arg2: "trigger", arg3: "ClearYomiprincess");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}