namespace Maple2.Trigger._52000029_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1001, 2001, 1002, 1003, 1004, 1005, 1006}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State구르는천둥Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구르는천둥Script01 : TriggerState {
            internal State구르는천둥Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001581, script: "$52000029_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State유페리아Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script01 : TriggerState {
            internal State유페리아Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, script: "$52000029_QD__MAIN__1$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 3022, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동2 : TriggerState {
            internal StateNPC이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동3 : TriggerState {
            internal StateNPC이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이펙트Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Cinematic : TriggerState {
            internal State이펙트Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {2001}, arg2: 71000003, arg3: 1, arg4: true, arg5: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIshura이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동01 : TriggerState {
            internal StateIshura이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateIshuraScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript01 : TriggerState {
            internal StateIshuraScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000029_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State홀슈타트방향전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트방향전환 : TriggerState {
            internal State홀슈타트방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State홀슈타트Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Script01 : TriggerState {
            internal State홀슈타트Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001231, script: "$52000029_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State홀슈타트도망(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트도망 : TriggerState {
            internal State홀슈타트도망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3055, arg2: true);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001_B");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateIshura추격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura추격 : TriggerState {
            internal StateIshura추격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1004, 1005, 1006});
                context.CreateMonster(arg1: new[] {1007, 1008, 1009, 1010, 1011, 1101, 1102, 1104, 1105, 1106}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPC집결(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC집결 : TriggerState {
            internal StateNPC집결(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_B");
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008_B");
                context.MoveNpc(arg1: 1009, arg2: "MS2PatrolData_1009_B");
                context.MoveNpc(arg1: 1010, arg2: "MS2PatrolData_1010_B");
                context.MoveNpc(arg1: 1011, arg2: "MS2PatrolData_1011_B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State렌듀비앙Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙Script01 : TriggerState {
            internal State렌듀비앙Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001230, script: "$52000029_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000032, script: "$52000029_QD__MAIN__5$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State제나Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제나Script01 : TriggerState {
            internal State제나Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001583, script: "$52000029_QD__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State유페리아Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script02 : TriggerState {
            internal State유페리아Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, script: "$52000029_QD__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateIshuraScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript02 : TriggerState {
            internal StateIshuraScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000029_QD__MAIN__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIshuraScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript03 : TriggerState {
            internal StateIshuraScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000029_QD__MAIN__9$", arg4: 11, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11500)) {
                    return new StateIshuraScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript04 : TriggerState {
            internal StateIshuraScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_D");
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000029_QD__MAIN__10$", arg4: 6, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State렌듀비앙Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙Script02 : TriggerState {
            internal State렌듀비앙Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001230, script: "$52000029_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State렌듀비앙이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동 : TriggerState {
            internal State렌듀비앙이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData_1007_C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State렌듀비앙캐스팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙캐스팅 : TriggerState {
            internal State렌듀비앙캐스팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1007}, arg2: 71000004, arg3: 1, arg4: true, arg5: false);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_C");
                context.CameraSelect(arg1: 309, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIshuraScript05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraScript05 : TriggerState {
            internal StateIshuraScript05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000029_QD__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 52000030, arg2: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
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