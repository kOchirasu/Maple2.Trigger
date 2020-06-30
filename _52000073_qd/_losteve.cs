using System;

namespace Maple2.Trigger._52000073_qd {
    public static class _losteve {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9900")) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001683},
                    arg3: new byte[] {3})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001683},
                    arg3: new byte[] {2})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001683},
                    arg3: new byte[] {1})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001682},
                    arg3: new byte[] {3})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001682},
                    arg3: new byte[] {2})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001682},
                    arg3: new byte[] {1})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001681},
                    arg3: new byte[] {3})) {
                    context.State = new State대원있음(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001681},
                    arg3: new byte[] {2})) {
                    context.State = new State대원등장(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001681},
                    arg3: new byte[] {1})) {
                    context.State = new State대원등장(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001680},
                    arg3: new byte[] {3})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001680},
                    arg3: new byte[] {2})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {50001680},
                    arg3: new byte[] {1})) {
                    context.State = new State기본상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본상태 : TriggerState {
            internal State기본상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {401});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9900")) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대원있음 : TriggerState {
            internal State대원있음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    // context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대원등장 : TriggerState {
            internal State대원등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {401});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대원대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대원대사 : TriggerState {
            internal State대원대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_pcTurn");
                context.CameraSelectPath(arg1: new int[] {8003, 8004}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_2001");
                context.AddCinematicTalk(npcID: 11003446, illustID: "0", msg: "$52000073_QD__LOSTEVE__0$",
                    duration: 4000, align: "right");
                context.FaceEmotion(spawnPointID: 101, emotionName: "Upset");
                context.SetSceneSkip(arg1: "연출종료", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카트반대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반대사 : TriggerState {
            internal State카트반대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000044, illustID: "0", msg: "$52000073_QD__LOSTEVE__1$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    // context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}