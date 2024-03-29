namespace Maple2.Trigger._99999950 {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEventUI(arg1: 1, script: "$99999950__MAIN__0$", duration: 2000, boxId: 0);
                    return new State1라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101001})) {
                    return new State1라운드02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드02 : TriggerState {
            internal State1라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101001})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드Wait : TriggerState {
            internal State2라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEventUI(arg1: 1, script: "$99999950__MAIN__1$", duration: 2000, boxId: 0);
                    return new State2라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101002})) {
                    return new State2라운드02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드02 : TriggerState {
            internal State2라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101002})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드Wait : TriggerState {
            internal State3라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEventUI(arg1: 1, script: "$99999950__MAIN__2$", duration: 2000, boxId: 0);
                    return new State3라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101003})) {
                    return new State3라운드02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드02 : TriggerState {
            internal State3라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101003})) {
                    return new State4라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드Wait : TriggerState {
            internal State4라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEventUI(arg1: 1, script: "$99999950__MAIN__3$", duration: 2000, boxId: 0);
                    return new State4라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101004})) {
                    return new State4라운드02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드02 : TriggerState {
            internal State4라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101004})) {
                    return new State4라운드03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드03 : TriggerState {
            internal State4라운드03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101004})) {
                    return new State5라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드Wait : TriggerState {
            internal State5라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEventUI(arg1: 1, script: "$99999950__MAIN__4$", duration: 2000, boxId: 0);
                    return new State5라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101005}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101005})) {
                    // return new State6라운드Wait(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
