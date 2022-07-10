namespace Maple2.Trigger._81000003_item {
    public static class _trigger_04 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{510, 511, 512, 513, 514, 515, 516}, visible: true);
                context.SetEffect(triggerIds: new []{701, 702}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{401})) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{510, 511, 512, 513, 514, 515, 516}, visible: false);
                context.SetEffect(triggerIds: new []{701, 702}, visible: true);
                context.SetTimer(timerId: "11", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State폭죽끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭죽끄기 : TriggerState {
            internal State폭죽끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 120);
                context.SetEffect(triggerIds: new []{701, 702}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
