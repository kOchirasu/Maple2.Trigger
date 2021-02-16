namespace Maple2.Trigger._52000034_qd {
    public static class _quest_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002600}, arg3: new byte[] {3})) {
                    return new StateDefaultNPCSpawn(context);
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
                    return new StateCinematic01시작(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002603}, arg3: new byte[] {2})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultNPCSpawn : TriggerState {
            internal StateDefaultNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic01시작 : TriggerState {
            internal StateCinematic01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.DestroyMonster(arg1: new[] {2001, 2002, 2003});
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State자베스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script01 : TriggerState {
            internal State자베스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자베스Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script02 : TriggerState {
            internal State자베스Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__1$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script01 : TriggerState {
            internal State브라보Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__2$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State브라보Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script02 : TriggerState {
            internal State브라보Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__3$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script03 : TriggerState {
            internal State브라보Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__4$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script03 : TriggerState {
            internal State자베스Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__5$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script04 : TriggerState {
            internal State자베스Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State브라보Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script04 : TriggerState {
            internal State브라보Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script05 : TriggerState {
            internal State브라보Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__8$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자베스Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script05 : TriggerState {
            internal State자베스Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__9$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자베스Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script06 : TriggerState {
            internal State자베스Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000034_QD__QUEST_01__10$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script06 : TriggerState {
            internal State브라보Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__11$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script07 : TriggerState {
            internal State브라보Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000034_QD__QUEST_01__12$", arg4: 3);
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
                    return new State제이시Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시Script01 : TriggerState {
            internal State제이시Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001690, script: "$52000034_QD__QUEST_01__13$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic01종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic01종료 : TriggerState {
            internal StateCinematic01종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
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