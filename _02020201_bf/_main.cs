using System;

namespace Maple2.Trigger._02020201_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 103, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State페이카등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이카등장 : TriggerState {
            internal State페이카등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020201_BF__MAIN__0$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State제단파괴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제단파괴 : TriggerState {
            internal State제단파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020201_BF__MAIN__1$");
                context.AddBalloonTalk(spawnPointID: 101, msg: "$02020201_BF__MAIN__2$", duration: 3000, delayTick: 0);
                context.DestroyMonster(arg1: new int[] {201, 202, 203});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "PaikaKritiasClear");
                context.DungeonClear();
                context.SetPortal(arg1: 103, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}