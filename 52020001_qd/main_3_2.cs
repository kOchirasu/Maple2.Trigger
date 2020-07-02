namespace Maple2.Trigger._52020001_qd {
    public static class _main_3_2 {
        public class State경고텍스트발생 : TriggerState {
            internal State경고텍스트발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new State경고텍스트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경고텍스트 : TriggerState {
            internal State경고텍스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"더이상 상대할 수 없습니다.\n포탑을 이용해 다른 곳으로 이동하세요.", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State경고텍스트_2(context);
                }

                if (context.GetUserValue(key: "respawn_end") == 2) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경고텍스트_2 : TriggerState {
            internal State경고텍스트_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"더이상 상대할 수 없습니다.\n포탑을 이용해 다른 곳으로 이동하세요.", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State경고텍스트(context);
                }

                if (context.GetUserValue(key: "respawn_end") == 2) {
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
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}