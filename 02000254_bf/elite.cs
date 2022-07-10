namespace Maple2.Trigger._02000254_bf {
    public static class _elite {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 801, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 802, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 803, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 804, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 805, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 806, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new StateDelay1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay1 : TriggerState {
            internal StateDelay1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State2탄(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2탄 : TriggerState {
            internal State2탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104});
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State3탄(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3탄 : TriggerState {
            internal State3탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
                context.CreateMonster(spawnIds: new []{105});
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State4탄(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4탄 : TriggerState {
            internal State4탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{104});
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State5탄(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5탄 : TriggerState {
            internal State5탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
                context.CreateMonster(spawnIds: new []{103});
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State2탄(context);
                }

                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new StateClearDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearDelay : TriggerState {
            internal StateClearDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateClear2(context);
            }

            public override void OnExit() { }
        }

        private class StateClear2 : TriggerState {
            internal StateClear2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 14);
                context.SetConversation(type: 2, spawnId: 11000057, script: "$02000254_BF__ELITE__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateClear3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear3 : TriggerState {
            internal StateClear3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.DestroyMonster(spawnIds: new []{103, 104, 105});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 801, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 802, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 803, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 804, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 805, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 806, visible: true, animationEffect: true);
                context.DungeonClear();
                context.HideGuideSummary(entityId: 20002524);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
