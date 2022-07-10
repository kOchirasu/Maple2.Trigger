namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_5phase {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "5Phase") == 1) {
                    return new State크림슨발록Spawn체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록Spawn체크 : TriggerState {
            internal State크림슨발록Spawn체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{241}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{242}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{243}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{244}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{245}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{246}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", boxIds: new []{247}, skillId: 49218001, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{241}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{242}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{243}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{244}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{245}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{246}, skillId: 49218002, level: 1, arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", boxIds: new []{247}, skillId: 49218002, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{242})) {
                    return new State크림슨스피어죽음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어죽음 : TriggerState {
            internal State크림슨스피어죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{241})) {
                    return new State발록에게신호쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발록에게신호쏴주기 : TriggerState {
            internal State발록에게신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "SpearDead", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
