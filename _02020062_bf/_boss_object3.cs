namespace Maple2.Trigger._02020062_bf {
    public static class _boss_object3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {713, 723});
                context.SetInteractObject(arg1: new[] {12000113}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 1) {
                    context.State = new State레버3_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_체크 : TriggerState {
            internal State레버3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {723}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {713})) {
                    context.State = new State레버3_발동(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_발동 : TriggerState {
            internal State레버3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000113}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000113}, arg2: 0)) {
                    context.State = new State레버3_안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_안내 : TriggerState {
            internal State레버3_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State레버3_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성 : TriggerState {
            internal State레버3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000113}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000113}, arg2: 0)) {
                    context.State = new State레버3_재활성_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성_대기 : TriggerState {
            internal State레버3_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State레버3_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {713, 723});
                context.SetInteractObject(arg1: new[] {12000113}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}