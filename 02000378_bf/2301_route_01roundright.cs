namespace Maple2.Trigger._02000378_bf {
    public static class _2301_route_01roundright {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {28011, 28012, 28013, 28014}, arg2: true);
                context.SetMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123, 430100, 430101, 430102, 430103, 430104, 430105, 430106, 430107, 430108, 430109, 430110, 430111, 430112, 430113, 430114, 430115, 430116, 430117, 430118, 430119, 430120, 430121, 430122, 430123}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateStartDazzling01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzling01 : TriggerState {
            internal StateStartDazzling01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RouteSelected") == 1) {
                    return new StateStartDazzlingRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDazzlingRandom01 : TriggerState {
            internal StateStartDazzlingRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: true, arg3: 8, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom02(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: false, arg3: 24, arg4: 0, arg5: 0);
            }
        }

        private class StateStartDazzlingRandom02 : TriggerState {
            internal StateStartDazzlingRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: true, arg3: 8, arg4: 100, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartDazzlingRandom01(context);
                }

                if (context.GetUserValue(key: "MakeTrue") == 1) {
                    return new StateMakeTrue(context);
                }

                if (context.GetUserValue(key: "MakeFalse") == 1) {
                    return new StateMakeFalse(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetRandomMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: false, arg3: 24, arg4: 0, arg5: 0);
            }
        }

        private class StateMakeTrue : TriggerState {
            internal StateMakeTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetRandomMesh(arg1: new[] {430100, 430101, 430102, 430103, 430104, 430105, 430106, 430107, 430108, 430109, 430110, 430111, 430112, 430113, 430114, 430115, 430116, 430117, 430118, 430119, 430120, 430121, 430122, 430123}, arg2: true, arg3: 24, arg4: 100, arg5: 50);
                context.SetAgent(arg1: new[] {28011, 28012, 28013, 28014}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMakeFalse : TriggerState {
            internal StateMakeFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {230100, 230101, 230102, 230103, 230104, 230105, 230106, 230107, 230108, 230109, 230110, 230111, 230112, 230113, 230114, 230115, 230116, 230117, 230118, 230119, 230120, 230121, 230122, 230123}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}