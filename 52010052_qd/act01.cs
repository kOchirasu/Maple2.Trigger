namespace Maple2.Trigger._52010052_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000074}, questStates: new byte[]{2})) {
                    return new StateNPC리젠03_담당관과트리스탄_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000050}, questStates: new byte[]{2})) {
                    return new StateNPC리젠02_담당관과트리스탄(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000037}, questStates: new byte[]{2})) {
                    return new StateNPC리젠01_5대세력담당관(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000075}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000074}, questStates: new byte[]{3})) {
                    return new StateNPC리젠03_담당관과트리스탄_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000063}, questStates: new byte[]{3})) {
                    return new StateNPC리젠01_5대세력담당관(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000058}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000057}, questStates: new byte[]{3})) {
                    return new StateNPC리젠01_5대세력담당관(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000050}, questStates: new byte[]{3})) {
                    return new StateNPC리젠02_담당관과트리스탄(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000043}, questStates: new byte[]{3})) {
                    return new StateNPC리젠03_트리스탄솔로(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000049}, questStates: new byte[]{3})) {
                    return new StateNPC리젠02_담당관과트리스탄(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000046}, questStates: new byte[]{3})) {
                    return new StateNPC리젠01_5대세력담당관(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000019}, questStates: new byte[]{3})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠03_트리스탄솔로 : TriggerState {
            internal StateNPC리젠03_트리스탄솔로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠01_5대세력담당관 : TriggerState {
            internal StateNPC리젠01_5대세력담당관(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠02_담당관과트리스탄 : TriggerState {
            internal StateNPC리젠02_담당관과트리스탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000057}, questStates: new byte[]{3})) {
                    return new State트리스탄삐짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄삐짐01 : TriggerState {
            internal State트리스탄삐짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003790, illustId: "Tristan_normal", script: "$52010052_QD__ACT01__0$", duration: 4000);
                context.MoveNpc(spawnId: 2005, patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리스탄삐짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄삐짐02 : TriggerState {
            internal State트리스탄삐짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{2005});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠03_담당관과트리스탄_02 : TriggerState {
            internal StateNPC리젠03_담당관과트리스탄_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
