namespace Maple2.Trigger._02020130_bf {
    public static class _skilldebuff_2phase {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SkillDebuffCheck_2Phase", value: 0);
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.SetUserValue(key: "FirstBattleEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new StateBoss의저주디Buff사용신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss의저주디Buff사용신호Wait : TriggerState {
            internal StateBoss의저주디Buff사용신호Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillDebuffCheck_2Phase") == 1) {
                    return new State소환몹활성화될때까지잠시기다리기(context);
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 1) {
                    return new State폭발저주디BuffRemoveWait(context);
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 99) {
                    return new State폭발저주디BuffRemove하고종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹활성화될때까지잠시기다리기 : TriggerState {
            internal State소환몹활성화될때까지잠시기다리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State소환몹전멸할때까지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹전멸할때까지Wait : TriggerState {
            internal State소환몹전멸할때까지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new State폭발저주디BuffRemoveWait(context);
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 1) {
                    return new State폭발저주디BuffRemoveWait(context);
                }

                if (context.GetUserValue(key: "FirstBattleEnd") == 99) {
                    return new State폭발저주디BuffRemove하고종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발저주디BuffRemoveWait : TriggerState {
            internal State폭발저주디BuffRemoveWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SkillDebuffCheck_2Phase", value: 0);
                context.SetUserValue(key: "FirstBattleEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new State폭발저주디BuffRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발저주디BuffRemove : TriggerState {
            internal State폭발저주디BuffRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{601}, skillId: 50001413, level: 1, arg4: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new StateBoss의저주디Buff사용신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발저주디BuffRemove하고종료 : TriggerState {
            internal State폭발저주디BuffRemove하고종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{601}, skillId: 50001413, level: 1, arg4: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
