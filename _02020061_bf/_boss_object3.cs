namespace Maple2.Trigger._02020061_bf {
    public static class _boss_object3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {713, 723});
                context.SetInteractObject(arg1: new[] {12000096}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 1) {
                    return new State레버3_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_체크 : TriggerState {
            internal State레버3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {723}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {713})) {
                    return new State레버3_발동(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_발동 : TriggerState {
            internal State레버3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000096}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000096}, arg2: 0)) {
                    return new State레버3_안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_안내 : TriggerState {
            internal State레버3_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new State레버3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성 : TriggerState {
            internal State레버3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000096}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000096}, arg2: 0)) {
                    return new State레버3_재활성_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성_대기 : TriggerState {
            internal State레버3_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new State레버3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {713, 723});
                context.SetInteractObject(arg1: new[] {12000096}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}