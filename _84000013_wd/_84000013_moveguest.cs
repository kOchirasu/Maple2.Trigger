using System;

namespace Maple2.Trigger._84000013_wd {
    public static class _84000013_moveguest {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State초기화(context);

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonystartsready", value: 0);
                context.SetUserValue(key: "Weddingceremonyfail", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "Weddingceremonystartsready", value: 1)) {
                    context.SetUserValue(key: "Weddingceremonystartsready", value: 0);
                    context.State = new State새로운하객있는지감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State새로운하객있는지감지 : TriggerState {
            internal State새로운하객있는지감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "Weddingceremonyfail", value: 1)) {
                    context.SetUserValue(key: "Weddingceremonyfail", value: 0);
                    context.State = new State시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State방금입장한하객은하객석으로위치이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방금입장한하객은하객석으로위치이동 : TriggerState {
            internal State방금입장한하객은하객석으로위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000013, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State새로운하객있는지감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State하객은버진로드밖으로위치이동 : TriggerState {
            internal State하객은버진로드밖으로위치이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000013, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State새로운하객있는지감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}