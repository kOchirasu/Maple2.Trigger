using Maple2.Trigger.Enum;

namespace Maple2.Trigger._84000022_wd {
    public static class _84000022_wait {
        public class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonyfail", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateStart_타이머설정(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_타이머설정 : TriggerState {
            internal StateStart_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4000", seconds: 2100, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                return new State위치세팅(context);
            }

            public override void OnExit() { }
        }

        private class State위치세팅 : TriggerState {
            internal State위치세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(type: WeddingEntryType.Guest, mapId: 84000022, portalIds: new []{22, 23}, boxId: 701);
            }

            public override TriggerState? Execute() {
                if (context.WeddingEntryInField(type: WeddingEntryType.Groom) && context.WeddingEntryInField(type: WeddingEntryType.Bride)) {
                    return new State둘다입장(context);
                }

                if (context.TimeExpired(timerId: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위치돌림 : TriggerState {
            internal State위치돌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(type: WeddingEntryType.Guest, mapId: 84000022, portalIds: new []{22, 23}, boxId: 701);
            }

            public override TriggerState? Execute() {
                return new State위치세팅(context);
            }

            public override void OnExit() { }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400131, textId: 28400131);
            }

            public override TriggerState? Execute() {
                if (context.WeddingEntryInField(type: WeddingEntryType.Groom) && context.WeddingEntryInField(type: WeddingEntryType.Bride)) {
                    return new State둘다입장(context);
                }

                if (context.TimeExpired(timerId: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400131);
            }
        }

        private class State둘다입장 : TriggerState {
            internal State둘다입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400133, textId: 28400133);
                context.SetUserValue(key: "StartWedding", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartWedding") == 1) {
                    return new State결혼확인띄우기(context);
                }

                if (context.TimeExpired(timerId: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400133);
            }
        }

        private class State결혼확인띄우기 : TriggerState {
            internal State결혼확인띄우기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(type: WeddingAgreeType.StartActing);
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonystartsready", value: 1);
            }

            public override TriggerState? Execute() {
                return new State결혼시작체크(context);
            }

            public override void OnExit() { }
        }

        private class State결혼시작체크 : TriggerState {
            internal State결혼시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.WeddingEntryInField(type: WeddingEntryType.Groom) || !context.WeddingEntryInField(type: WeddingEntryType.Bride)) {
                    return new StateWait01(context);
                }

                if (context.WeddingMutualAgreeResult(type: WeddingAgreeType.StartActing) == true) {
                    return new State결혼식Cinematic진행중(context);
                }

                if (context.WeddingMutualAgreeResult(type: WeddingAgreeType.StartActing) == true == false) {
                    return new StateWait01(context);
                }

                if (context.TimeExpired(timerId: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WeddingMoveUser(type: WeddingEntryType.Guest, mapId: 84000022, portalIds: new []{22, 23}, boxId: 701);
            }
        }

        private class State강퇴안내 : TriggerState {
            internal State강퇴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400132, textId: 28400132);
                context.WeddingBroken();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State강퇴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강퇴 : TriggerState {
            internal State강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 28400132);
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State결혼식Cinematic진행중 : TriggerState {
            internal State결혼식Cinematic진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4001, key: "Weddingceremonystarts", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Weddingceremonyfail") == 1) {
                    context.SetUserValue(key: "Weddingceremonyfail", value: 0);
                    return new State위치세팅(context);
                }

                if (context.WeddingHallState(hallState: "weddingComplete")) {
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
