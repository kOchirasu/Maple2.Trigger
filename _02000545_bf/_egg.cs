namespace Maple2.Trigger._02000545_bf {
    public static class _egg {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702}, arg2: 0)) {
                    context.State = new State아르키아체력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르키아체력 : TriggerState {
            internal State아르키아체력(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 102) <= 0.55f) {
                    context.State = new State알메쉬생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알메쉬생성 : TriggerState {
            internal State알메쉬생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300010, illust: "ArakiaDark_normal", duration: 4000,
                    script: "$02000545_BF__EGG__0$");
                context.SetMesh(arg1: new[] {2133, 2134}, arg2: true);
                context.CreateMonster(arg1: new[] {501, 502}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {501})) {
                    context.State = new State알파괴1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {502})) {
                    context.State = new State알파괴2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {501, 502})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알파괴1 : TriggerState {
            internal State알파괴1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2133}, arg2: false);
                context.SetAiExtraData(key: "phase", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {502})) {
                    context.State = new State알파괴2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {501, 502})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알파괴2 : TriggerState {
            internal State알파괴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2134}, arg2: false);
                context.SetAiExtraData(key: "phase", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {501})) {
                    context.State = new State알파괴1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {501, 502})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2133, 2134}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}