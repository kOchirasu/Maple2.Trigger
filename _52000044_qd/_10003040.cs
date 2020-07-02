namespace Maple2.Trigger._52000044_qd {
    public static class _10003040 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000390}, arg2: 0);
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003042}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.CreateMonster(arg1: new[] {1003}, arg2: false);
                    return new StateInteractObject대기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003041}, arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.CreateMonster(arg1: new[] {1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003041}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.CreateMonster(arg1: new[] {1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                if (context.QuestUserDetected(arg1: new[] {103}, arg2: new[] {10003041}, arg3: new byte[] {1})) {
                    return new StateStartCinematic02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003041}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.CreateMonster(arg1: new[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State말풍선대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic02 : TriggerState {
            internal StateStartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.CreateMonster(arg1: new[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State1차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선대사01 : TriggerState {
            internal State말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000044_QD__10003040__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State말풍선대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선대사02 : TriggerState {
            internal State말풍선대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 1, arg2: 2003, arg3: "$52000044_QD__10003040__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State제이시대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시대사01 : TriggerState {
            internal State제이시대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000044_QD__10003040__2$", arg4: 2);
                context.SetSkip(arg1: "제이시대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State제이시대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시대사01스킵 : TriggerState {
            internal State제이시대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State제이시대사02(context);
            }

            public override void OnExit() { }
        }

        private class State제이시대사02 : TriggerState {
            internal State제이시대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000044_QD__10003040__3$", arg4: 4);
                context.SetSkip(arg1: "제이시대사02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시대사02스킵 : TriggerState {
            internal State제이시대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State1차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작 : TriggerState {
            internal State1차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200441, textId: 25200441, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001, 2002, 2003, 2004, 2005})) {
                    context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
                    return new State2차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2006})) {
                    context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
                    return new StateNPC감지대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC감지대기 : TriggerState {
            internal StateNPC감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "EscapewithJacy");
                    context.DestroyMonster(arg1: new[] {1002});
                    context.CreateMonster(arg1: new[] {1003}, arg2: false);
                    return new StateInteractObject조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject조건 : TriggerState {
            internal StateInteractObject조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003042}, arg3: new byte[] {1})) {
                    return new StateInteractObject대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject대기 : TriggerState {
            internal StateInteractObject대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000390}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000390}, arg2: 0)) {
                    context.MoveUser(arg1: 52000045, arg2: 1);
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