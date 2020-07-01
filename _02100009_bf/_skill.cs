namespace Maple2.Trigger._02100009_bf {
    public static class _skill {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "Fencebreak", value: 0);
                context.SetMesh(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {1000001, 1000002, 1000003, 1000004, 1000005, 1000006, 1000007, 1000008, 1000008, 1000008, 1000008, 1000008, 1000009, 1000010, 1000011, 1000012, 1000013, 1000014, 1000015, 1000016, 1000017, 1000018, 1000019, 1000020, 1000021, 1000022, 1000023, 1000024, 1000025, 1000026, 1000027, 1000028, 1000029, 1000030, 1000031, 1000032, 1000033, 1000034, 1000035, 1000036, 1000037, 1000038, 1000039, 1000040, 1000041, 1000042, 1000043, 1000044, 1000045, 1000046, 1000047, 1000048}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State유저감지(context);
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State스킬사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬사용 : TriggerState {
            internal State스킬사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FenceBreak") == 1) {
                    return new State길막삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길막삭제 : TriggerState {
            internal State길막삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {1000001, 1000002, 1000003, 1000004, 1000005, 1000006, 1000007, 1000008, 1000008, 1000008, 1000008, 1000008, 1000009, 1000010, 1000011, 1000012, 1000013, 1000014, 1000015, 1000016, 1000017, 1000018, 1000019, 1000020, 1000021, 1000022, 1000023, 1000024, 1000025, 1000026, 1000027, 1000028, 1000029, 1000030, 1000031, 1000032, 1000033, 1000034, 1000035, 1000036, 1000037, 1000038, 1000039, 1000040, 1000041, 1000042, 1000043, 1000044, 1000045, 1000046, 1000047, 1000048}, arg2: false);
            }

            public override TriggerState Execute() {
                if (true) {
                    // return new State끝1(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}