namespace Maple2.Trigger._02000048_bf {
    public static class _fire_08 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000313}, arg2: 1);
                context.SetMesh(arg1: new[] {208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {308}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000313}, arg2: 0)) {
                    return new State오브젝트반응(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {208}, arg2: true, arg3: 0, arg4: 0, arg5: 1f);
                context.SetEffect(arg1: new[] {308}, arg2: true);
                context.CreateMonster(arg1: new[] {408}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 408, arg3: "$02000048_BF__FIRE_08__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State몬스터와전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터와전투 : TriggerState {
            internal State몬스터와전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {408})) {
                    return new State딜레이(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {408})) {
                    return new State몬스터소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {408})) {
                    context.ResetTimer(arg1: "1");
                }

                if (context.MonsterDead(arg1: new[] {408})) {
                    return new State소멸대기(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State소멸대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State딜레이(context);
                }

                if (context.MonsterInCombat(arg1: new[] {408})) {
                    return new State몬스터소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {408});
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}