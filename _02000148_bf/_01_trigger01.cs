namespace Maple2.Trigger._02000148_bf {
    public static class _01_trigger01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000109}, arg2: 1);
                context.SetEffect(arg1: new[] {201, 202, 203, 204}, arg2: false);
                context.SetMesh(arg1: new[] {325, 326, 303, 304}, arg2: true);
                context.SetMesh(arg1: new[] {305, 306, 307, 308}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000109}, arg2: 0)) {
                    return new State개봉박두(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개봉박두 : TriggerState {
            internal State개봉박두(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {325, 326, 303, 304}, arg2: false);
                context.CreateMonster(arg1: new[] {91, 92, 93, 94}, arg2: true);
                context.SetMesh(arg1: new[] {305, 306, 307, 308}, arg2: true);
                context.SetEffect(arg1: new[] {201, 202, 203, 204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91, 92, 93, 94})) {
                    return new State유저감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {401})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}