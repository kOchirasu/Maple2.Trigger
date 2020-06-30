using System;

namespace Maple2.Trigger._02000337_bf {
    public static class _boss {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7301}, arg2: false);
                context.SetEffect(arg1: new int[] {7302}, arg2: false);
                context.SetEffect(arg1: new int[] {7303}, arg2: false);
                context.SetEffect(arg1: new int[] {7304}, arg2: false);
                context.SetEffect(arg1: new int[] {7305}, arg2: false);
                context.SetEffect(arg1: new int[] {7306}, arg2: false);
                context.SetEffect(arg1: new int[] {7307}, arg2: false);
                context.SetEffect(arg1: new int[] {7308}, arg2: false);
                context.SetEffect(arg1: new int[] {7309}, arg2: false);
                context.SetEffect(arg1: new int[] {7310}, arg2: true);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State폭발예고(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발예고 : TriggerState {
            internal State폭발예고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 8002, arg2: true);
                context.SetMesh(arg1: new int[] {6001, 6002, 6003, 6004}, arg2: false, arg4: 0, arg5: 10f);
                context.SetEffect(arg1: new int[] {7308}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State폭발(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발 : TriggerState {
            internal State폭발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7306}, arg2: true);
                context.SetSkill(arg1: new int[] {8306}, arg2: true);
                context.SetSkill(arg1: new int[] {8307}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State폭발후(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State폭발후 : TriggerState {
            internal State폭발후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8002, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 111, textID: 20003371);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new State폭발후_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
            }
        }

        private class State폭발후_02 : TriggerState {
            internal State폭발후_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 112, textID: 20003372);
                context.SetInteractObject(arg1: new int[] {10000891}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000891}, arg2: 0)) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 112);
            }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202});
                context.SetEffect(arg1: new int[] {7301}, arg2: false);
                context.SetEffect(arg1: new int[] {7302}, arg2: false);
                context.SetEffect(arg1: new int[] {7303}, arg2: false);
                context.SetEffect(arg1: new int[] {7304}, arg2: false);
                context.SetEffect(arg1: new int[] {7305}, arg2: false);
                context.SetEffect(arg1: new int[] {7306}, arg2: false);
                context.SetEffect(arg1: new int[] {7307}, arg2: false);
                context.SetEffect(arg1: new int[] {7308}, arg2: false);
                context.SetEffect(arg1: new int[] {7309}, arg2: false);
                context.SetEffect(arg1: new int[] {7310}, arg2: false);
                context.SetEffect(arg1: new int[] {7311}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_Dark_Ending_Chord_01");
                context.SetActor(arg1: 5001, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5002, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5003, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5004, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5005, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5006, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5007, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5008, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이홍_대사01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }
        }

        private class State웨이홍_대사01 : TriggerState {
            internal State웨이홍_대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {199});
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003124, arg3: "$02000337_BF__BOSS__0$", arg4: 3);
                context.SetSkip(arg1: "웨이홍_대사02");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이홍_대사02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State웨이홍_대사02 : TriggerState {
            internal State웨이홍_대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003124, arg3: "$02000337_BF__BOSS__1$", arg4: 3);
                context.SetSkip(arg1: "종료");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State웨이홍_대사03 : TriggerState {
            internal State웨이홍_대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003124, arg3: "$02000337_BF__BOSS__2$", arg4: 3);
                context.SetSkip(arg1: "종료");
                context.SetTimer(arg1: "4", arg2: 4, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000337_BF__BOSS__3$", arg4: 3, arg5: 2);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}