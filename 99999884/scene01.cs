namespace Maple2.Trigger._99999884 {
    public static class _scene01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401, 402, 403, 404}, arg2: false);
                context.SetActor(arg1: 405, arg2: false);
                context.SetEffect(arg1: new[] {406}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Spawn : TriggerState {
            internal State벨라Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202});
                context.SetEffect(arg1: new[] {401}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script1 : TriggerState {
            internal State벨라Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$99999884__SCENE01__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script2 : TriggerState {
            internal State벨라Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__1$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State프레이와오스칼Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이와오스칼Spawn : TriggerState {
            internal State프레이와오스칼Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {204});
                context.SetEffect(arg1: new[] {402}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State프레이Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script1 : TriggerState {
            internal State프레이Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11000119, arg3: "$99999884__SCENE01__2$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script3 : TriggerState {
            internal State벨라Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetEffect(arg1: new[] {402}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__3$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script4 : TriggerState {
            internal State벨라Script4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToDevorak");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__4$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State이펙트지연(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트지연 : TriggerState {
            internal State이펙트지연(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {402}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State프레이Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script2 : TriggerState {
            internal State프레이Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.MoveNpc(arg1: 203, arg2: "203_MS2PatrolData_Frey_MoveToBella");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$99999884__SCENE01__5$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script5 : TriggerState {
            internal State벨라Script5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {402}, arg2: false);
                context.SetEffect(arg1: new[] {403}, arg2: true);
                context.MoveNpc(arg1: 202, arg2: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$99999884__SCENE01__6$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State프레이피격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이피격 : TriggerState {
            internal State프레이피격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 203, arg2: "203_MS2PatrolData_Frey_HitByBella");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State오스칼Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script1 : TriggerState {
            internal State오스칼Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.DestroyMonster(arg1: new[] {203});
                context.SetEffect(arg1: new[] {403}, arg2: false);
                context.SetEffect(arg1: new[] {406}, arg2: true);
                context.SetActor(arg1: 405, arg2: true, arg3: "Down_Idle_A");
                context.MoveNpc(arg1: 204, arg2: "204_MS2PatrolData_Oskhal_MoveToFrey");
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$99999884__SCENE01__7$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State오스칼Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script2 : TriggerState {
            internal State오스칼Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$99999884__SCENE01__8$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State오스칼돌격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼돌격 : TriggerState {
            internal State오스칼돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.MoveNpc(arg1: 204, arg2: "204_MS2PatrolData_Oskhal_MoveToBella");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {302}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}