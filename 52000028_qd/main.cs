namespace Maple2.Trigger._52000028_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602, 603, 604}, arg2: false);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {20002250}, arg3: new byte[] {1}, arg4: 90)) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {20002251}, arg3: new byte[] {1}, arg4: 90)) {
                    return new StateNPC이동01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {10002931}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {10002932}, arg3: new byte[] {1})) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아시모프이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프이동 : TriggerState {
            internal State아시모프이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1001})) {
                    return new State책장변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State책장변경 : TriggerState {
            internal State책장변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State동영상재상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상재상 : TriggerState {
            internal State동영상재상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Starlight_expedition.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateIshura대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대사01 : TriggerState {
            internal StateIshura대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000028_QD__MAIN__0$", arg4: 5, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateIshura대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura대사02 : TriggerState {
            internal StateIshura대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000028_QD__MAIN__1$", arg4: 6, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아시모프대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프대사01 : TriggerState {
            internal State아시모프대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001_B");
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, arg3: "$52000028_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아시모프대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프대사02 : TriggerState {
            internal State아시모프대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000031, arg3: "$52000028_QD__MAIN__3$", arg4: 6, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuest수락대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "BackstoryOfRune");
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateQuest수락대기 : TriggerState {
            internal StateQuest수락대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {20002251}, arg3: new byte[] {1}, arg4: 90)) {
                    return new StateNPC이동01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {10002932}, arg3: new byte[] {1})) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1005, arg2: "MS2PatrolData_1005_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1008, arg2: "MS2PatrolData_1008_A");
                context.MoveNpc(arg1: 1013, arg2: "MS2PatrolData_1013_A");
                context.MoveNpc(arg1: 1014, arg2: "MS2PatrolData_1014_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
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