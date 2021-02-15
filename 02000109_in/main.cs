namespace Maple2.Trigger._02000109_in {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: true);
                context.SetMesh(arg1: new[] {4011}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {2})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {1})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new State벽삭제(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    return new StateNpcSpawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {2})) {
                    return new StateNpcSpawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행체크 : TriggerState {
            internal StateQuest진행체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {2})) {
                    // return new State일기장Spawn(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001608}, arg3: new byte[] {1})) {
                    // return new State일기장Spawn(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    // return new State일기장Spawn(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new State벽삭제(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    return new StateNpcSpawn(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {2})) {
                    return new StateNpcSpawn(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn_Wait : TriggerState {
            internal StateNpcSpawn_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new State벽삭제(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new StateQuest진행체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new State벽삭제(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {1})) {
                    return new StateQuest진행체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new StateQuest진행체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일기장Spawn_Wait : TriggerState {
            internal State일기장Spawn_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {4011}, arg2: true);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new State일기장Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일기장Spawn01 : TriggerState {
            internal State일기장Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4011}, arg2: true);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    return new State일기장없어짐(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new State일기장Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일기장Spawn02 : TriggerState {
            internal State일기장Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4011}, arg2: true);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    return new State일기장없어짐(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {3})) {
                    return new State일기장Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일기장없어짐 : TriggerState {
            internal State일기장없어짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetMesh(arg1: new[] {4011, 4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new State일기장Spawn_Wait(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001607}, arg3: new byte[] {2})) {
                    return new StateQuest진행체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}