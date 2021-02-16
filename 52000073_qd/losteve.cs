using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000073_qd {
    public static class _losteve {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {2})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001683}, arg3: new byte[] {1})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {3})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {2})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001682}, arg3: new byte[] {1})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {3})) {
                    return new State대원Exists(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {2})) {
                    return new State대원Spawn(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {50001681}, arg3: new byte[] {1})) {
                    return new State대원Spawn(context);
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
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대원Exists : TriggerState {
            internal State대원Exists(ITriggerContext context) : base(context) { }

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

        private class State대원Spawn : TriggerState {
            internal State대원Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
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
                context.CameraSelectPath(pathIds: new[] {8003, 8004}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_2001");
                context.AddCinematicTalk(npcId: 11003446, illustId: "0", script: "$52000073_QD__LOSTEVE__0$", duration: 4000, align: Align.Right);
                context.FaceEmotion(spawnPointId: 101, emotionName: "Upset");
                context.SetSceneSkip(state: new StateStopCinematic(context), arg2: "exit");
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
                context.AddCinematicTalk(npcId: 11000044, illustId: "0", script: "$52000073_QD__LOSTEVE__1$", duration: 4000, align: Align.Right);
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
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