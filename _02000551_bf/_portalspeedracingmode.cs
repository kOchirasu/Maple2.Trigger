namespace Maple2.Trigger._02000551_bf {
    public static class _portalspeedracingmode {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State순간이동포탈감추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State순간이동포탈감추기 : TriggerState {
            internal State순간이동포탈감추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12000, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3000, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6000, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9000, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12202, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4501, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4502, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7801, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7802, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10111, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10112, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13003, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13006, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13009, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13012, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13121, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13031, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13061, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13091, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpeedRacingMode") == 1) {
                    return new State순간이동포탈등장(context);
                }

                if (context.GetUserValue(key: "SpeedRacingMode") == 2) {
                    return new State종료딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State순간이동포탈등장 : TriggerState {
            internal State순간이동포탈등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12000, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3000, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6000, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9000, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12201, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12202, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4501, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4502, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7801, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7802, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10111, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10112, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13003, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13006, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13009, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13012, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13121, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13031, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13061, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13091, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpeedRacingMode") == 0) {
                    return new State잠시대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시대기 : TriggerState {
            internal State잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State순간이동포탈감추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    return new State순간이동포탈등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}