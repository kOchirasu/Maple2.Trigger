namespace Maple2.Trigger._02020144_bf {
    public static class __main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1003, arg2: 70002151, arg3: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State보스전_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_시작 : TriggerState {
            internal State보스전_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal",
                    script: "$02020101_BF__MAIN__0$", duration: 5670, voice: @"ko/Npc/00002206");
                context.CreateMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5670)) {
                    context.State = new State조건추가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State보스전_성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_성공 : TriggerState {
            internal State보스전_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "ClearGreenLapenta_Quest");
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SideNpcTalk(type: "talk", npcId: 23501001, illust: "Turned_Yuperia_normal",
                    script: "$02020101_BF__MAIN__1$", duration: 7940, voice: @"ko/Npc/00002207");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7940)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}