namespace Maple2.Trigger._02000545_bf {
    public static class _egg2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702}, arg2: 0)) {
                    return new State아르키아체력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르키아체력 : TriggerState {
            internal State아르키아체력(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 102) <= 0.30f) {
                    return new State알메쉬Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알메쉬Creation : TriggerState {
            internal State알메쉬Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300010, illust: "ArakiaDark_normal", duration: 4000, script: "$02000545_BF__EGG2__0$");
                context.SetMesh(arg1: new[] {2150, 2151}, arg2: true);
                context.CreateMonster(arg1: new[] {505, 507}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {505})) {
                    return new State알파괴1(context);
                }

                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State알파괴2(context);
                }

                if (context.MonsterDead(arg1: new[] {505, 507})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알파괴1 : TriggerState {
            internal State알파괴1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2150}, arg2: false);
                context.SetAiExtraData(key: "phase", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {507})) {
                    return new State알파괴2(context);
                }

                if (context.MonsterDead(arg1: new[] {505, 507})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알파괴2 : TriggerState {
            internal State알파괴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2151}, arg2: false);
                context.SetAiExtraData(key: "phase", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {505})) {
                    return new State알파괴1(context);
                }

                if (context.MonsterDead(arg1: new[] {505, 507})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2150, 2151}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}