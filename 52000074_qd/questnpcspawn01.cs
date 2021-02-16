namespace Maple2.Trigger._52000074_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002679}, arg3: new byte[] {3})) {
                    return new StateNpcRemove01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002679}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002679}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002678}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002678}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002678}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002677}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002677}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002677}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002676}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002676}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002676}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002675}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002675}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002675}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002674}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002674}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002674}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002673}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002673}, arg3: new byte[] {2})) {
                    return new StateNpcTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcRemove01 : TriggerState {
            internal StateNpcRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraSet01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraSet01 : TriggerState {
            internal StateCameraSet01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateTalkEnd01(context), arg2: "exit");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEveTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk01 : TriggerState {
            internal StateEveTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001962, arg3: "$52000074_QD__QUESTNPCSPAWN01__0$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk01Skip : TriggerState {
            internal StateEveTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLennonTalk01(context);
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01 : TriggerState {
            internal StateLennonTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001961, arg3: "$52000074_QD__QUESTNPCSPAWN01__1$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLennonTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01Skip : TriggerState {
            internal StateLennonTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateEveTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02 : TriggerState {
            internal StateEveTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001962, arg3: "$52000074_QD__QUESTNPCSPAWN01__2$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEveTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02Skip : TriggerState {
            internal StateEveTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkEnd01 : TriggerState {
            internal StateTalkEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}