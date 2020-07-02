namespace Maple2.Trigger._52000062_qd {
    public static class _guidescene_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1007}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000561}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000561}, arg3: new byte[] {2})) {
                    return new State연퀘감지2(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000560, 90000561}, arg3: new byte[] {1})) {
                    return new State연퀘감지(context);
                }

                if (context.UserDetected(arg1: new[] {199})) {
                    return new State페르시카대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페르시카대사01 : TriggerState {
            internal State페르시카대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State페르시카대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페르시카대사02 : TriggerState {
            internal State페르시카대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001176, arg3: "$52000062_QD__GUIdESCENE_01__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001176, arg3: "$52000062_QD__GUIdESCENE_01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State연퀘감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연퀘감지 : TriggerState {
            internal State연퀘감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_Fercika");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {90000561}, arg3: new byte[] {2})) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연퀘감지2 : TriggerState {
            internal State연퀘감지2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_Fercika");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {198})) {
                    return new State찬양NPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찬양NPC이동 : TriggerState {
            internal State찬양NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_Fercika2");
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.DestroyMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.DestroyMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
                context.DestroyMonster(arg1: new[] {1007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 197, arg2: new[] {1001})) {
                    return new State찬양연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State찬양연출 : TriggerState {
            internal State찬양연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1008, arg3: "$52000062_QD__GUIdESCENE_01__2$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 1005, arg3: "$52000062_QD__GUIdESCENE_01__3$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 1006, arg3: "$52000062_QD__GUIdESCENE_01__4$", arg4: 2, arg5: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStopCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic2 : TriggerState {
            internal StateStopCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}