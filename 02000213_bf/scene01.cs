namespace Maple2.Trigger._02000213_bf {
    public static class _scene01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201});
                context.SetEffect(triggerIds: new []{401, 601, 602, 603, 604, 605, 606, 607, 608, 609}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
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
                    return new State데보라크대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데보라크대사 : TriggerState {
            internal State데보라크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetConversation(type: 2, spawnId: 23000007, script: "$02000213_BF__SCENE01__0$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State레논Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Spawn : TriggerState {
            internal State레논Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203});
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State레논Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script1 : TriggerState {
            internal State레논Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetEffect(triggerIds: new []{606}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$02000213_BF__SCENE01__1$", arg4: 2);
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
                context.SetTimer(timerId: "1", seconds: 2);
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
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000213_BF__SCENE01__2$", arg4: 4);
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
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000213_BF__SCENE01__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State알론Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Spawn : TriggerState {
            internal State알론Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204});
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State알론Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Script1 : TriggerState {
            internal State알론Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{607}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$02000213_BF__SCENE01__4$", arg4: 4);
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
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000213_BF__SCENE01__5$", arg4: 4);
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
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000213_BF__SCENE01__6$", arg4: 4);
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
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000213_BF__SCENE01__7$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라사라짐이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라사라짐이펙트 : TriggerState {
            internal State벨라사라짐이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{407}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벨라사라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라사라짐 : TriggerState {
            internal State벨라사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{302}, returnView: true);
                context.DestroyMonster(spawnIds: new []{202, 203, 204});
                context.CreateMonster(spawnIds: new []{205});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State알론Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Script2 : TriggerState {
            internal State알론Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetConversation(type: 1, spawnId: 205, script: "$02000213_BF__SCENE01__8$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State알론Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Script3 : TriggerState {
            internal State알론Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.SetConversation(type: 1, spawnId: 205, script: "$02000213_BF__SCENE01__9$", arg4: 4);
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
                context.CameraSelect(triggerId: 301, enable: false);
                context.SetTimer(timerId: "1", seconds: 2);
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
