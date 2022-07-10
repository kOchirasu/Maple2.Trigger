using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020200_bf {
    public static class _11_balloontalk {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{905})) {
                    return new StateScript1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript1 : TriggerState {
            internal StateScript1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020200_BF__11_BALLOONTALK__0$");
                context.AddBalloonTalk(spawnId: 0, msg: "$02020200_BF__11_BALLOONTALK__1$", duration: 5000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{921}) && !context.MonsterDead(spawnIds: new []{205})) {
                    return new StateScript2(context);
                }

                if (context.UserDetected(boxIds: new []{922}) && !context.MonsterDead(spawnIds: new []{205})) {
                    return new StateScript2(context);
                }

                if (context.UserDetected(boxIds: new []{923}) && !context.MonsterDead(spawnIds: new []{205})) {
                    return new StateScript2(context);
                }

                if (context.MonsterDead(spawnIds: new []{205})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript2 : TriggerState {
            internal StateScript2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02020200_BF__11_BALLOONTALK__2$", duration: 5000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 205, additionalEffectId: 42030261, level: 1)) {
                    return new StateScript3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScript3 : TriggerState {
            internal StateScript3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020200_BF__11_BALLOONTALK__3$");
                context.AddBalloonTalk(spawnId: 0, msg: "$02020200_BF__11_BALLOONTALK__4$", duration: 5000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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
