using System;

namespace Maple2.Trigger._02100004_bf {
    public static class _randomspawner {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "RoundStart", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤스폰 : TriggerState {
            internal State랜덤스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 0);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크08(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크09(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크11(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크12(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State중복체크13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크01 : TriggerState {
            internal State중복체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned01", value: 0)) {
                    context.SetUserValue(triggerID: 999101, key: "NpcSpawn01", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned01", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크02 : TriggerState {
            internal State중복체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned02", value: 0)) {
                    context.SetUserValue(triggerID: 999102, key: "NpcSpawn02", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned02", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크03 : TriggerState {
            internal State중복체크03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned03", value: 0)) {
                    context.SetUserValue(triggerID: 999103, key: "NpcSpawn03", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned03", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크04 : TriggerState {
            internal State중복체크04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned04", value: 0)) {
                    context.SetUserValue(triggerID: 999104, key: "NpcSpawn04", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned04", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크05 : TriggerState {
            internal State중복체크05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned05", value: 0)) {
                    context.SetUserValue(triggerID: 999105, key: "NpcSpawn05", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned05", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크06 : TriggerState {
            internal State중복체크06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned06", value: 0)) {
                    context.SetUserValue(triggerID: 999106, key: "NpcSpawn06", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned06", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크08 : TriggerState {
            internal State중복체크08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned08", value: 0)) {
                    context.SetUserValue(triggerID: 999108, key: "NpcSpawn08", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned08", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크09 : TriggerState {
            internal State중복체크09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned09", value: 0)) {
                    context.SetUserValue(triggerID: 999109, key: "NpcSpawn09", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned09", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크10 : TriggerState {
            internal State중복체크10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned10", value: 0)) {
                    context.SetUserValue(triggerID: 999110, key: "NpcSpawn10", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned10", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크11 : TriggerState {
            internal State중복체크11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned11", value: 0)) {
                    context.SetUserValue(triggerID: 999111, key: "NpcSpawn11", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned11", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크12 : TriggerState {
            internal State중복체크12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned12", value: 0)) {
                    context.SetUserValue(triggerID: 999112, key: "NpcSpawn12", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned12", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중복체크13 : TriggerState {
            internal State중복체크13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawned13", value: 0)) {
                    context.SetUserValue(triggerID: 999113, key: "NpcSpawn13", value: 1);
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "NpcSpawned13", value: 1)) {
                    context.State = new State랜덤스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}