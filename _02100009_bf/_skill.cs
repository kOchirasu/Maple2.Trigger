using System;

namespace Maple2.Trigger._02100009_bf {
    public static class _skill {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 100, key: "Fencebreak", value: 0);
                context.SetMesh(arg1: new int[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {1000001}, arg2: true);
                context.SetSkill(arg1: new int[] {1000002}, arg2: true);
                context.SetSkill(arg1: new int[] {1000003}, arg2: true);
                context.SetSkill(arg1: new int[] {1000004}, arg2: true);
                context.SetSkill(arg1: new int[] {1000005}, arg2: true);
                context.SetSkill(arg1: new int[] {1000006}, arg2: true);
                context.SetSkill(arg1: new int[] {1000007}, arg2: true);
                context.SetSkill(arg1: new int[] {1000008}, arg2: true);
                context.SetSkill(arg1: new int[] {1000008}, arg2: true);
                context.SetSkill(arg1: new int[] {1000008}, arg2: true);
                context.SetSkill(arg1: new int[] {1000008}, arg2: true);
                context.SetSkill(arg1: new int[] {1000008}, arg2: true);
                context.SetSkill(arg1: new int[] {1000009}, arg2: true);
                context.SetSkill(arg1: new int[] {1000010}, arg2: true);
                context.SetSkill(arg1: new int[] {1000011}, arg2: true);
                context.SetSkill(arg1: new int[] {1000012}, arg2: true);
                context.SetSkill(arg1: new int[] {1000013}, arg2: true);
                context.SetSkill(arg1: new int[] {1000014}, arg2: true);
                context.SetSkill(arg1: new int[] {1000015}, arg2: true);
                context.SetSkill(arg1: new int[] {1000016}, arg2: true);
                context.SetSkill(arg1: new int[] {1000017}, arg2: true);
                context.SetSkill(arg1: new int[] {1000018}, arg2: true);
                context.SetSkill(arg1: new int[] {1000019}, arg2: true);
                context.SetSkill(arg1: new int[] {1000020}, arg2: true);
                context.SetSkill(arg1: new int[] {1000021}, arg2: true);
                context.SetSkill(arg1: new int[] {1000022}, arg2: true);
                context.SetSkill(arg1: new int[] {1000023}, arg2: true);
                context.SetSkill(arg1: new int[] {1000024}, arg2: true);
                context.SetSkill(arg1: new int[] {1000025}, arg2: true);
                context.SetSkill(arg1: new int[] {1000026}, arg2: true);
                context.SetSkill(arg1: new int[] {1000027}, arg2: true);
                context.SetSkill(arg1: new int[] {1000028}, arg2: true);
                context.SetSkill(arg1: new int[] {1000029}, arg2: true);
                context.SetSkill(arg1: new int[] {1000030}, arg2: true);
                context.SetSkill(arg1: new int[] {1000031}, arg2: true);
                context.SetSkill(arg1: new int[] {1000032}, arg2: true);
                context.SetSkill(arg1: new int[] {1000033}, arg2: true);
                context.SetSkill(arg1: new int[] {1000034}, arg2: true);
                context.SetSkill(arg1: new int[] {1000035}, arg2: true);
                context.SetSkill(arg1: new int[] {1000036}, arg2: true);
                context.SetSkill(arg1: new int[] {1000037}, arg2: true);
                context.SetSkill(arg1: new int[] {1000038}, arg2: true);
                context.SetSkill(arg1: new int[] {1000039}, arg2: true);
                context.SetSkill(arg1: new int[] {1000040}, arg2: true);
                context.SetSkill(arg1: new int[] {1000041}, arg2: true);
                context.SetSkill(arg1: new int[] {1000042}, arg2: true);
                context.SetSkill(arg1: new int[] {1000043}, arg2: true);
                context.SetSkill(arg1: new int[] {1000044}, arg2: true);
                context.SetSkill(arg1: new int[] {1000045}, arg2: true);
                context.SetSkill(arg1: new int[] {1000046}, arg2: true);
                context.SetSkill(arg1: new int[] {1000047}, arg2: true);
                context.SetSkill(arg1: new int[] {1000048}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State스킬사용(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬사용 : TriggerState {
            internal State스킬사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "FenceBreak", value: 1)) {
                    context.State = new State길막삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길막삭제 : TriggerState {
            internal State길막삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {1000001}, arg2: false);
                context.SetSkill(arg1: new int[] {1000002}, arg2: false);
                context.SetSkill(arg1: new int[] {1000003}, arg2: false);
                context.SetSkill(arg1: new int[] {1000004}, arg2: false);
                context.SetSkill(arg1: new int[] {1000005}, arg2: false);
                context.SetSkill(arg1: new int[] {1000006}, arg2: false);
                context.SetSkill(arg1: new int[] {1000007}, arg2: false);
                context.SetSkill(arg1: new int[] {1000008}, arg2: false);
                context.SetSkill(arg1: new int[] {1000008}, arg2: false);
                context.SetSkill(arg1: new int[] {1000008}, arg2: false);
                context.SetSkill(arg1: new int[] {1000008}, arg2: false);
                context.SetSkill(arg1: new int[] {1000008}, arg2: false);
                context.SetSkill(arg1: new int[] {1000009}, arg2: false);
                context.SetSkill(arg1: new int[] {1000010}, arg2: false);
                context.SetSkill(arg1: new int[] {1000011}, arg2: false);
                context.SetSkill(arg1: new int[] {1000012}, arg2: false);
                context.SetSkill(arg1: new int[] {1000013}, arg2: false);
                context.SetSkill(arg1: new int[] {1000014}, arg2: false);
                context.SetSkill(arg1: new int[] {1000015}, arg2: false);
                context.SetSkill(arg1: new int[] {1000016}, arg2: false);
                context.SetSkill(arg1: new int[] {1000017}, arg2: false);
                context.SetSkill(arg1: new int[] {1000018}, arg2: false);
                context.SetSkill(arg1: new int[] {1000019}, arg2: false);
                context.SetSkill(arg1: new int[] {1000020}, arg2: false);
                context.SetSkill(arg1: new int[] {1000021}, arg2: false);
                context.SetSkill(arg1: new int[] {1000022}, arg2: false);
                context.SetSkill(arg1: new int[] {1000023}, arg2: false);
                context.SetSkill(arg1: new int[] {1000024}, arg2: false);
                context.SetSkill(arg1: new int[] {1000025}, arg2: false);
                context.SetSkill(arg1: new int[] {1000026}, arg2: false);
                context.SetSkill(arg1: new int[] {1000027}, arg2: false);
                context.SetSkill(arg1: new int[] {1000028}, arg2: false);
                context.SetSkill(arg1: new int[] {1000029}, arg2: false);
                context.SetSkill(arg1: new int[] {1000030}, arg2: false);
                context.SetSkill(arg1: new int[] {1000031}, arg2: false);
                context.SetSkill(arg1: new int[] {1000032}, arg2: false);
                context.SetSkill(arg1: new int[] {1000033}, arg2: false);
                context.SetSkill(arg1: new int[] {1000034}, arg2: false);
                context.SetSkill(arg1: new int[] {1000035}, arg2: false);
                context.SetSkill(arg1: new int[] {1000036}, arg2: false);
                context.SetSkill(arg1: new int[] {1000037}, arg2: false);
                context.SetSkill(arg1: new int[] {1000038}, arg2: false);
                context.SetSkill(arg1: new int[] {1000039}, arg2: false);
                context.SetSkill(arg1: new int[] {1000040}, arg2: false);
                context.SetSkill(arg1: new int[] {1000041}, arg2: false);
                context.SetSkill(arg1: new int[] {1000042}, arg2: false);
                context.SetSkill(arg1: new int[] {1000043}, arg2: false);
                context.SetSkill(arg1: new int[] {1000044}, arg2: false);
                context.SetSkill(arg1: new int[] {1000045}, arg2: false);
                context.SetSkill(arg1: new int[] {1000046}, arg2: false);
                context.SetSkill(arg1: new int[] {1000047}, arg2: false);
                context.SetSkill(arg1: new int[] {1000048}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    // context.State = new State끝1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}