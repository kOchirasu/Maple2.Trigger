namespace Maple2.Trigger._99999884 {
    public static class _scene01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{401, 402, 403, 404}, visible: false);
                context.SetActor(triggerId: 405, visible: false);
                context.SetEffect(triggerIds: new []{406}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Spawn : TriggerState {
            internal State벨라Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202});
                context.SetEffect(triggerIds: new []{401}, visible: true);
                context.SetTimer(timerId: "1", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script1 : TriggerState {
            internal State벨라Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{401}, visible: false);
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$99999884__SCENE01__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script2 : TriggerState {
            internal State벨라Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetConversation(type: 1, spawnId: 202, script: "$99999884__SCENE01__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State프레이와오스칼Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이와오스칼Spawn : TriggerState {
            internal State프레이와오스칼Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203});
                context.CreateMonster(spawnIds: new []{204});
                context.SetEffect(triggerIds: new []{402}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State프레이Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script1 : TriggerState {
            internal State프레이Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11000119, script: "$99999884__SCENE01__2$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script3 : TriggerState {
            internal State벨라Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetEffect(triggerIds: new []{402}, visible: false);
                context.MoveNpc(spawnId: 202, patrolName: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(type: 1, spawnId: 202, script: "$99999884__SCENE01__3$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script4 : TriggerState {
            internal State벨라Script4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.MoveNpc(spawnId: 202, patrolName: "202_MS2PatrolData_Bella_TurnToDevorak");
                context.SetConversation(type: 1, spawnId: 202, script: "$99999884__SCENE01__4$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State이펙트지연(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트지연 : TriggerState {
            internal State이펙트지연(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{402}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State프레이Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script2 : TriggerState {
            internal State프레이Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.MoveNpc(spawnId: 203, patrolName: "203_MS2PatrolData_Frey_MoveToBella");
                context.SetConversation(type: 1, spawnId: 203, script: "$99999884__SCENE01__5$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라Script5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script5 : TriggerState {
            internal State벨라Script5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{402}, visible: false);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.MoveNpc(spawnId: 202, patrolName: "202_MS2PatrolData_Bella_TurnToFrey");
                context.SetConversation(type: 1, spawnId: 202, script: "$99999884__SCENE01__6$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State프레이피격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이피격 : TriggerState {
            internal State프레이피격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.MoveNpc(spawnId: 203, patrolName: "203_MS2PatrolData_Frey_HitByBella");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State오스칼Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script1 : TriggerState {
            internal State오스칼Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.DestroyMonster(spawnIds: new []{203});
                context.SetEffect(triggerIds: new []{403}, visible: false);
                context.SetEffect(triggerIds: new []{406}, visible: true);
                context.SetActor(triggerId: 405, visible: true, initialSequence: "Down_Idle_A");
                context.MoveNpc(spawnId: 204, patrolName: "204_MS2PatrolData_Oskhal_MoveToFrey");
                context.SetConversation(type: 2, spawnId: 11000015, script: "$99999884__SCENE01__7$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State오스칼Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script2 : TriggerState {
            internal State오스칼Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetConversation(type: 1, spawnId: 204, script: "$99999884__SCENE01__8$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State오스칼돌격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼돌격 : TriggerState {
            internal State오스칼돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.MoveNpc(spawnId: 204, patrolName: "204_MS2PatrolData_Oskhal_MoveToBella");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{302}, returnView: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
