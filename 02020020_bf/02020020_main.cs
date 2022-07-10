using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020020_bf {
    public static class _02020020_main {
        public class StateCamera_네이린설명1 : TriggerState {
            internal StateCamera_네이린설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", script: "$02020020_BF__02020020_main__0$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", script: "$02020020_BF__02020020_main__1$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", script: "$02020020_BF__02020020_main__2$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
