namespace Maple2.Trigger._52000034_qd {
    public static class _quest_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002600}, arg3: new byte[] {3})) {
                    return new State기본NPCSpawn(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002600}, arg3: new byte[] {3})) {
                    return new State제이시추가배치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시추가배치 : TriggerState {
            internal State제이시추가배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001, 2002, 2003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002603}, arg3: new byte[] {2})) {
                    return new State연출01시작(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002603}, arg3: new byte[] {2})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본NPCSpawn : TriggerState {
            internal State기본NPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State연출01시작 : TriggerState {
            internal State연출01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.DestroyMonster(arg1: new[] {2001, 2002, 2003});
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State자베스대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사01 : TriggerState {
            internal State자베스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자베스대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사02 : TriggerState {
            internal State자베스대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__1$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사01 : TriggerState {
            internal State브라보대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__2$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State브라보대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사02 : TriggerState {
            internal State브라보대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__3$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사03 : TriggerState {
            internal State브라보대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__4$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사03 : TriggerState {
            internal State자베스대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__5$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사04 : TriggerState {
            internal State자베스대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사04 : TriggerState {
            internal State브라보대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사05 : TriggerState {
            internal State브라보대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__8$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사05 : TriggerState {
            internal State자베스대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__9$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자베스대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사06 : TriggerState {
            internal State자베스대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000034_QD__QUEST_01__10$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사06 : TriggerState {
            internal State브라보대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__11$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보대사07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사07 : TriggerState {
            internal State브라보대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000034_QD__QUEST_01__12$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제이시대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시대사01 : TriggerState {
            internal State제이시대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001690, arg3: "$52000034_QD__QUEST_01__13$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State연출01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출01종료 : TriggerState {
            internal State연출01종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {1003});
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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