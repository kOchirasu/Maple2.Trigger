using System;

namespace Maple2.Trigger._52000074_qd {
    public static class _questnpcspawn01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 201}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002679},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcRemove01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002679},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002679},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002678},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002678},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002678},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002677},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002677},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002677},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002676},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002676},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002676},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002675},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002675},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002675},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002674},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002674},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002674},
                    arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002673},
                    arg3: new byte[] {3})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002673},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraSet01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraSet01 : TriggerState {
            internal StateCameraSet01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "TalkEnd01", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEveTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEveTalk01 : TriggerState {
            internal StateEveTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001962, arg3: "$52000074_QD__QUESTNPCSPAWN01__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEveTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEveTalk01Skip : TriggerState {
            internal StateEveTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateLennonTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01 : TriggerState {
            internal StateLennonTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001961, arg3: "$52000074_QD__QUESTNPCSPAWN01__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateLennonTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01Skip : TriggerState {
            internal StateLennonTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEveTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02 : TriggerState {
            internal StateEveTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001962, arg3: "$52000074_QD__QUESTNPCSPAWN01__2$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEveTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02Skip : TriggerState {
            internal StateEveTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkEnd01 : TriggerState {
            internal StateTalkEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}