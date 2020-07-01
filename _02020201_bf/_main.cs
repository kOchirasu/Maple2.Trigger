namespace Maple2.Trigger._02020201_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 103, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State페이카등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State페이카등장 : TriggerState {
            internal State페이카등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020201_BF__MAIN__0$");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State제단파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단파괴 : TriggerState {
            internal State제단파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020201_BF__MAIN__1$");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$02020201_BF__MAIN__2$", duration: 3000, delayTick: 0);
                context.DestroyMonster(arg1: new[] {201, 202, 203});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State종료(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}