namespace Maple2.Trigger._02000297_bf {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: false);
                context.DestroyMonster(arg1: new[] {1005, 1006, 1007});
                context.SetMesh(arg1: new[] {107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {31000, 31001, 31002, 31003, 31004, 31005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
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
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {107}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 888888, arg2: true);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData1");
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State레논01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논01 : TriggerState {
            internal State레논01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, script: "$02000297_BF__MAIN2__0$", arg4: 2);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State벨라01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라01 : TriggerState {
            internal State벨라01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000297_BF__MAIN2__1$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000297_BF__MAIN2__2$", arg4: 3);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9925)) {
                    return new State벨라02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라02 : TriggerState {
            internal State벨라02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData3");
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State레논02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논02 : TriggerState {
            internal State레논02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, script: "$02000297_BF__MAIN2__3$", arg4: 2);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State레논03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class State레논03 : TriggerState {
            internal State레논03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1004, 1001});
                context.CreateMonster(arg1: new[] {1005, 1008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State블랙01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙01 : TriggerState {
            internal State블랙01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData0");
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$02000297_BF__MAIN2__4$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$02000297_BF__MAIN2__5$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000297_BF__MAIN2__6$", arg4: 3);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCamera복귀(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera복귀 : TriggerState {
            internal StateCamera복귀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1002});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 888888, arg2: false);
                context.SetMesh(arg1: new[] {107, 31000, 31001, 31002, 31003, 31004, 31005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {6200}, arg2: false);
                context.DestroyMonster(arg1: new[] {1003, 1002, 1001, 1004});
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: true);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
                context.SetUserValue(triggerId: 999991, key: "BattleStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {6200})) {
                    return new State엔딩Cinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic1 : TriggerState {
            internal State엔딩Cinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {31000, 31001, 31002, 31003, 31004, 31005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State엔딩Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic : TriggerState {
            internal State엔딩Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 888888, arg2: true);
                context.DestroyMonster(arg1: new[] {1006});
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData5");
                context.SetSkip(state: new StateStopCinematic2(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State블랙03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블랙03 : TriggerState {
            internal State블랙03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$02000297_BF__MAIN2__7$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000064, script: "$02000297_BF__MAIN2__8$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, script: "$02000297_BF__MAIN2__9$", arg4: 3);
                context.SetSkip(state: new StateStopCinematic2(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11101)) {
                    return new StateStopCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic2 : TriggerState {
            internal StateStopCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
                context.CameraSelect(arg1: 888888, arg2: false);
                context.DestroyMonster(arg1: new[] {1005, 1008, 1007});
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "ClearKatramusSecond");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}