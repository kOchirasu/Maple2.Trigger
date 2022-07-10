using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020144_bf {
    public static class __main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 1003, skillId: 70002151, arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1002})) {
                    return new StateBoss_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_시작 : TriggerState {
            internal StateBoss_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__0$", duration: 5670, voice: @"ko/Npc/00002206");
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5670)) {
                    return new State조건추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Success : TriggerState {
            internal StateBoss_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "ClearGreenLapenta_Quest");
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501001, illust: "Turned_Yuperia_normal", script: "$02020101_BF__MAIN__1$", duration: 7940, voice: @"ko/Npc/00002207");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7940)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
