namespace Maple2.Trigger._80000014_bonus {
    public static class _spawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001326, 10001327, 10001328, 10001329, 10001330, 10001331, 10001332, 10001333}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State랜덤A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤A : TriggerState {
            internal State랜덤A(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001326}, arg2: 1);
                    return new State랜덤B(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1501}, arg2: false);
                    return new State랜덤B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤B : TriggerState {
            internal State랜덤B(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001327}, arg2: 1);
                    return new State랜덤C(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1502}, arg2: false);
                    return new State랜덤C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤C : TriggerState {
            internal State랜덤C(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001328}, arg2: 1);
                    return new State랜덤D(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1503}, arg2: false);
                    return new State랜덤D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤D : TriggerState {
            internal State랜덤D(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001329}, arg2: 1);
                    return new State랜덤E(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1504}, arg2: false);
                    return new State랜덤E(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤E : TriggerState {
            internal State랜덤E(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001330}, arg2: 1);
                    return new State랜덤F(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1505}, arg2: false);
                    return new State랜덤F(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤F : TriggerState {
            internal State랜덤F(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001331}, arg2: 1);
                    return new State랜덤G(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1506}, arg2: false);
                    return new State랜덤G(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤G : TriggerState {
            internal State랜덤G(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001332}, arg2: 1);
                    return new State랜덤H(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1507}, arg2: false);
                    return new State랜덤H(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤H : TriggerState {
            internal State랜덤H(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001333}, arg2: 1);
                    return new State스폰1(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001333}, arg2: 1);
                    return new State스폰1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰1 : TriggerState {
            internal State스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new State스폰2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰2 : TriggerState {
            internal State스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {113})) {
                    return new State스폰3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰3 : TriggerState {
            internal State스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    return new State스폰4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰4 : TriggerState {
            internal State스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1053, 1054, 1055, 1056, 1057, 1058, 1059}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {115})) {
                    return new State스폰5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰5 : TriggerState {
            internal State스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {116})) {
                    return new State스폰6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰6 : TriggerState {
            internal State스폰6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}