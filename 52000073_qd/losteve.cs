namespace Maple2.Trigger._52000073_qd {
    public static class _losteve {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건체크 : TriggerState {
            internal StateQuest조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {2})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {1})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {3})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {2})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {1})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {3})) {
                    return new State대원있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {2})) {
                    return new State대원Appear(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {1})) {
                    return new State대원Appear(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001680}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001680}, arg3: new byte[] {2})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001680}, arg3: new byte[] {1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {401});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대원있음 : TriggerState {
            internal State대원있음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    // return new StateEnd(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대원Appear : TriggerState {
            internal State대원Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {401});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대원대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대원대사 : TriggerState {
            internal State대원대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_pcTurn");
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_2001");
                context.AddCinematicTalk(npcId: 11003446, illustId: "0", msg: "$52000073_QD__LOSTEVE__0$", duration: 4000, align: "right");
                context.FaceEmotion(spawnPointId: 101, emotionName: "Upset");
                context.SetSceneSkip(arg1: "StopCinematic", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카트반대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반대사 : TriggerState {
            internal State카트반대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000044, illustId: "0", msg: "$52000073_QD__LOSTEVE__1$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    // return new StateEnd(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}