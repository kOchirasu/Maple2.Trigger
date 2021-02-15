namespace Maple2.Trigger._02020061_bf {
    public static class _boss_object4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {714, 724});
                context.SetInteractObject(arg1: new[] {12000097}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 1) {
                    return new StateLever4_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever4_체크 : TriggerState {
            internal StateLever4_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {724}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {714})) {
                    return new StateLever4_발동(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever4_발동 : TriggerState {
            internal StateLever4_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000097}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000097}, arg2: 0)) {
                    return new StateLever4_안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever4_안내 : TriggerState {
            internal StateLever4_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever4_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever4_재활성 : TriggerState {
            internal StateLever4_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000097}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000097}, arg2: 0)) {
                    return new StateLever4_재활성_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever4_재활성_Wait : TriggerState {
            internal StateLever4_재활성_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {921}) && context.MonsterDead(arg1: new[] {922}) && context.MonsterDead(arg1: new[] {923}) && context.MonsterDead(arg1: new[] {924}) && context.MonsterDead(arg1: new[] {925}) && context.MonsterDead(arg1: new[] {926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever4_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(arg1: new[] {714, 724});
                context.SetInteractObject(arg1: new[] {12000097}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}