using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020201_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 103, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new State페이카Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페이카Spawn : TriggerState {
            internal State페이카Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020201_BF__MAIN__0$");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State제단파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단파괴 : TriggerState {
            internal State제단파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020201_BF__MAIN__1$");
                context.AddBalloonTalk(spawnId: 101, msg: "$02020201_BF__MAIN__2$", duration: 3000, delayTick: 0);
                context.DestroyMonster(spawnIds: new []{201, 202, 203});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "PaikaKritiasClear");
                context.DungeonClear();
                context.SetPortal(portalId: 103, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
