namespace Maple2.Trigger._02000304_bf {
    public static class _move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateMonster체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster체크 : TriggerState {
            internal StateMonster체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{2001})) {
                    return new StateCountRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCountRandom : TriggerState {
            internal StateCountRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new State이동Wait01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State이동Wait02(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State이동Wait03(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State이동Wait04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait01 : TriggerState {
            internal State이동Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "90", seconds: 90);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "90")) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait02 : TriggerState {
            internal State이동Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100", seconds: 100);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "100")) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait03 : TriggerState {
            internal State이동Wait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "110", seconds: 110);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "110")) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait04 : TriggerState {
            internal State이동Wait04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "120", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "120")) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MOVE__0$", arg4: 2);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MOVE__1$", arg4: 1);
                    context.MoveRandomUser(mapId: 02000304, portalId: 11, triggerId: 101, count: 1);
                    return new State이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동2 : TriggerState {
            internal State이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MOVE__2$", arg4: 1);
                    context.MoveRandomUser(mapId: 02000304, portalId: 12, triggerId: 101, count: 1);
                    return new State이동3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동3 : TriggerState {
            internal State이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MOVE__3$", arg4: 1);
                    context.MoveRandomUser(mapId: 02000304, portalId: 13, triggerId: 101, count: 1);
                    return new State이동4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동4 : TriggerState {
            internal State이동4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MOVE__4$", arg4: 1);
                    context.MoveRandomUser(mapId: 02000304, portalId: 14, triggerId: 101, count: 1);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
