namespace Maple2.Trigger._02000428_bf {
    public static class _event01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateWaitCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat : TriggerState {
            internal StateWaitCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleStart_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart_InfernoWarship : TriggerState {
            internal StateBattleStart_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041002, textId: 20041002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State첫번째Phase_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041002);
            }
        }

        private class State첫번째Phase_InfernoWarship : TriggerState {
            internal State첫번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AirshipBalrogCrimsonBroken") == 1) {
                    return new StateInfernoWarship파괴Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴Cinematic : TriggerState {
            internal StateInfernoWarship파괴Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041010, textId: 20041010);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__Event01__0$", voice: @"ko/Npc/00002167");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateInfernoWarship파괴Cinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴Cinematic2 : TriggerState {
            internal StateInfernoWarship파괴Cinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__Event01__1$", voice: @"ko/Npc/00002158");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State두번째Phase_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041010);
            }
        }

        private class State두번째Phase_InfernoWarship : TriggerState {
            internal State두번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AirshipBalrogCrimsonFlameBroken") == 1) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041011, textId: 20041011);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__Event01__2$", voice: @"ko/Npc/00002168");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041011);
            }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic2 : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 4000, script: "$02000410_BF__Event01__3$", voice: @"ko/Npc/00002169");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic3 : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_closeEye", duration: 5200, script: "$02000410_BF__Event01__4$", voice: @"ko/Npc/00002159");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic4 : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02000410_BF__Event01__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic5 : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02000410_BF__Event01__9$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateInfernoWarship파괴_인페르녹SpawnCinematic6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInfernoWarship파괴_인페르녹SpawnCinematic6 : TriggerState {
            internal StateInfernoWarship파괴_인페르녹SpawnCinematic6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__Event01__7$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State세번째Phase_인페르녹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Phase_인페르녹Spawn : TriggerState {
            internal State세번째Phase_인페르녹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BalrogMagicBursterBattlePhase") == 1) {
                    // return new StateSuccess이벤트실행(context);
                    return null;
                }

                if (context.GetUserValue(key: "BalrogMagicBursterBattlePhase") == 1) {
                    // return new State실패이벤트실행(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
