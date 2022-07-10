using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020028_bf {
    public static class _main {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24120001, illustId: "Neirin_normal", script: "$02020028_BF__main__0$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 24120001, illustId: "Neirin_normal", script: "$02020028_BF__main__1$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
